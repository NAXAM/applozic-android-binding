﻿using System;
using Android.Content;
using Java.Lang;
using Com.Applozic.Mobicomkit.Uiwidgets.Conversation;
using Com.Applozic.Mobicomkit.Api.Account.Register;
using Com.Applozic.Mobicomkit.Api.Account.User;
using ApplozicUser = Com.Applozic.Mobicomkit.Api.Account.User.User;
using UserLogoutTask = Com.Applozic.Mobicomkit.Api.Account.User.UserLogoutTask;
using System.Collections.Generic;
using MobiComUserPreference = Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference;
using ConversationActivity = Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity;
using MobicomkitApplozic = Com.Applozic.Mobicomkit.Applozic;
namespace Applozic
{
    public class ApplozicChatManager
    {
        Context context;
        public ApplozicChatManager(Context context)
        {
            this.context = context;
        }
        /*
		 * Check if Applozic user is logged in already 
		 * 
		 */

        public bool ISUserLoggedIn()
        {
            var applozicPref = MobiComUserPreference.GetInstance(context);
            return applozicPref.IsRegistered;
        }

        /*
		 */

        public void RegisterUser(string userId, string displayName, string password, UserLoginListener userLoginListener)
        {
            // Build Applozic users..
            var user = new ApplozicUser();
            user.DisplayName = displayName;
            user.UserId = userId;
            user.Password = password;
            List<string> featureList = new List<string>();
            featureList.Add(User.Features.IpAudioCall.Value);// FOR AUDIO
            featureList.Add(User.Features.IpVideoCall.Value);// FOR VIDEO
            user.SetFeatures(featureList); // ADD FEATURES 
            user.AuthenticationTypeId = new Short("1");
            Java.Lang.Void[] args = null;
            new UserLoginTask(user, userLoginListener, context).Execute(args);
        }

        /*
		 */

        public void RegisterUser(ApplozicUser applozicUser, UserLoginListener userLoginListener)
        {
            // Build Applozic users..

            Java.Lang.Void[] args = null;
            new UserLoginTask(applozicUser, userLoginListener, context).Execute(args);
        }

        /**
		 * This is the example of shows
		 * 
		 */
        public void LaunchChatList()
        {
            //context.StartActivity(typeof(Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity));
            // Android.Util.Log.Debug("inside1", contactGroupId);
            Intent myIntent = new Intent(context, typeof(ConversationActivity.ConversationActivity));
            context.StartActivity(myIntent);
        }
        /**
		 * 
		 */
        public void LaunchChatWithUser(string receiverUserId)
        {
            Intent myIntent = new Intent(context, typeof(ConversationActivity.ConversationActivity));
            myIntent.PutExtra("takeOrder", true);
            myIntent.PutExtra(ConversationUIService.USER_ID, receiverUserId);
            myIntent.PutExtra(ConversationUIService.DISPLAY_NAME, "DISPLAY_NAME");

            context.StartActivity(myIntent);
        }

        /**
		 * 
		 */
        public void Logout(UserLogoutListener userLogoutListener)
        {
            Java.Lang.Void[] args = null;
            new UserLogoutTask(userLogoutListener, context).Execute(args);

        }

        /**
		 * 
		 */

        public void SendRegistrationToServer(string token)
        {
            MobicomkitApplozic.GetInstance(context).SetDeviceRegistrationId(token);
            // Add custom implementation, as needed.
            var applozicPref = MobiComUserPreference.GetInstance(context);
            if (applozicPref.IsRegistered)
            {
                var registerClient = new RegisterUserClientService(context);
                registerClient.UpdatePushNotificationId(token);
            }
        }

    }


    /**
	 * 
	 * Class for initialising chat..
	 */
    public class UserLoginListener : Java.Lang.Object, UserLoginTask.ITaskListener
    {
        public delegate void OnRegistrationSucess(RegistrationResponse res, Context context);
        public delegate void OnRegistrationFailed(RegistrationResponse res, Java.Lang.Exception e);
        public event OnRegistrationSucess OnRegistrationSucessHandler;
        public event OnRegistrationFailed OnRegistrationFailedHandler;


        //RegistrationResponse registrationResponse, Context context
        public void OnSuccess(RegistrationResponse res, Context context)
        {
            System.Console.WriteLine("Successfully registered " + res.Message);
            PushNotificationListener PushRegisterListener = new PushNotificationListener();
            Java.Lang.Void[] args = null;
            string deviceRegistartionId = MobicomkitApplozic.GetInstance(context).DeviceRegistrationId;
            if (!Android.Text.TextUtils.IsEmpty(deviceRegistartionId))
            {
                new PushNotificationTask(deviceRegistartionId, PushRegisterListener, context).Execute(args);
            }
            //Send call back to caller
            if (OnRegistrationSucessHandler != null)
            {
                OnRegistrationSucessHandler(res, context);
            }

        }

        public void OnFailure(RegistrationResponse res, Java.Lang.Exception e)
        {
            System.Console.WriteLine("Exception ::" + e.Message);

            //Send call back to caller
            if (OnRegistrationFailedHandler != null)
            {
                OnRegistrationFailedHandler(res, e);
            }
        }



    }



    /**
	 * 
	 * Class for initialising chat..
	 */
    public class UserLogoutListener : Java.Lang.Object, UserLogoutTask.ITaskListener
    {
        public delegate void OnLogoutSucess(Context context);
        public delegate void OnLogoutFailed(Java.Lang.Exception e);
        public event OnLogoutSucess OnLogoutSucessHandler;
        public event OnLogoutFailed OnLogoutFailedHandler;
        //RegistrationResponse registrationResponse, Context context
        public void OnSuccess(Context context)
        {
            System.Console.WriteLine("Logged out sucessfully");
            if (OnLogoutSucessHandler != null)
            {
                OnLogoutSucessHandler(context);
            }
        }

        public void OnFailure(Java.Lang.Exception e)
        {
            System.Console.WriteLine("Exception ::" + e.Message);
            OnLogoutFailedHandler(e);
        }


    }

    /**
	 * 
	 * Class for initialising chat..
	 */
    public class PushNotificationListener : Java.Lang.Object, PushNotificationTask.ITaskListener
    {

        public void OnSuccess(RegistrationResponse res)
        {
            System.Console.WriteLine("Push notification sent sucessfully::" + res.Message);

        }

        public void OnFailure(RegistrationResponse res, Java.Lang.Exception e)
        {
            System.Console.WriteLine("Exception ::" + e.Message);


        }

    }

}
