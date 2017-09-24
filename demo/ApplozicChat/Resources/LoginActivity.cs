﻿
using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Applozic;
using Com.Applozic.Mobicomkit.Api.Account.Register;
using Com.Applozic.Mobicommons.People.Channel;
using Android.Util;

namespace ApplozicChat
{
    [Activity(Label = "Login", MainLauncher = true, Icon = "@mipmap/icon")]
    public class LoginActivity : Activity
    {

        private UserLoginListener loginListener;
        private AddMemberListner addMemberListner;
        ApplozicContactService contactService;
        // String contactGroupId = "GroupName";        // Enable this and pass your GroupID here  
        EditText userName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            loginListener = new UserLoginListener();
            loginListener.OnRegistrationSucessHandler += OnRegistrationSucessHandler;
            loginListener.OnRegistrationFailedHandler += OnRegistrationFailedHandler;
            // AddMemberHandler();                    // Enable this method for its handler when adding members to contact group 

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login_activity_layout);

            // Get our button from the layout resource,
            // and attach an event to it
            userName = FindViewById<EditText>(Resource.Id.username_input);
            EditText password = FindViewById<EditText>(Resource.Id.password_input);
            Button signIn = FindViewById<Button>(Resource.Id.sign_in_btn);
            ApplozicChatManager chatManager = new ApplozicChatManager(this);


            signIn.Click += delegate
            {
                chatManager.RegisterUser(userName.Text, userName.Text, password.Text, loginListener);
            };

            if (chatManager.ISUserLoggedIn())
            {
                System.Console.WriteLine("Already Registred ::");
                Intent myIntent = new Intent(this, typeof(MainActivity));
                this.StartActivity(myIntent);
                this.Finish();
            }


        }


        void OnRegistrationSucessHandler(RegistrationResponse res, Context context)
        {
            System.Console.WriteLine("Successfully got callback in LoginActivity :" + res.Message);

            // Enable  below commented code for adding member to contact group

            /*  contactService = new ApplozicContactService(this);        
               contactService.AddMemberToContactGroup(this, contactGroupId, (String)(Channel.GroupType.ContactGroup.Value), userName.Text, addMemberListner);
               var applozicPref = Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference.GetInstance(context);
               applozicPref.ContactsGroupId = contactGroupId;  */

            Intent myIntent = new Intent(this, typeof(MainActivity));
            this.StartActivity(myIntent);
            this.Finish();
        }

        void OnRegistrationFailedHandler(RegistrationResponse res, Java.Lang.Exception exception)
        {
            System.Console.WriteLine("Error while doing registrations:" + exception.Message);

            Toast.MakeText(ApplicationContext, "Login Failed : " + exception.Message, ToastLength.Long).Show();
        }


        void OnAddMemberSucessHandler(bool res, Context context)
        {

            System.Console.WriteLine("Successfully got callback for AddMember in LoginActivity :" + res);
        }

        void OnAddMemberFailedHandler(bool res, Java.Lang.Exception exception, Context context)
        {

            System.Console.WriteLine("Error while Adding Member:" + exception.Message);

            Toast.MakeText(ApplicationContext, "Adding Failed : " + exception.Message, ToastLength.Long).Show();
        }

        // Enable below commented code for adding contact group handler

        /*    public void AddMemberHandler()
            {
                addMemberListner = new AddMemberListner();
                addMemberListner.OnAddMemberSucessHandler += OnAddMemberSucessHandler;
                addMemberListner.OnAddMemberFailedHandler += OnAddMemberFailedHandler;
            } */
    }

}
