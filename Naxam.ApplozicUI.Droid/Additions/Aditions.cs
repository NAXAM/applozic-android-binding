using System.Linq;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Async
{
    partial class AlChannelAddMemberTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class AlChannelCreateAsyncTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class AlGroupInformationAsyncTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackgroundChild(@params);
        }
    }
    partial class AlSyncAccountStatusTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicAddMemberToMultipleChannels
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicAddMemberToContactGroupTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackgroundChild(@params);
        }
    }
    partial class ApplozicChannelAddMemberTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity
{
    partial class ChannelCreateActivity
    {
        partial class ProfilePictureUpload
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }

    partial class ChannelNameActivity
    {
        partial class ProfilePictureUpload
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }

    partial class ChannelInfoActivity
    {
        partial class ChannelMember
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
        partial class ChannelAsync
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
        partial class ChannelMemberAdd
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.People.Channel
{
    partial class ChannelFragment
    {

        void Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnLoadFinished(
            Android.Support.V4.Content.Loader loader,
            Java.Lang.Object data)
        {
            OnLoadFinished(loader, Android.Runtime.Extensions.JavaCast<Android.Database.ICursor>(data));
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.People.Contact
{
    partial class AppContactFragment
    {
        void Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnLoadFinished(
               Android.Support.V4.Content.Loader loader,
               Java.Lang.Object data)
        {
            OnLoadFinished(loader, Android.Runtime.Extensions.JavaCast<Android.Database.ICursor>(data));
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.People.Contact
{
    partial class ContactSelectionFragment
    {
        void Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnLoadFinished(
               Android.Support.V4.Content.Loader loader,
               Java.Lang.Object data)
        {
            OnLoadFinished(loader, Android.Runtime.Extensions.JavaCast<Android.Database.ICursor>(data));
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment
{
    partial class ContactsListFragment
    {
        void Android.Support.V4.App.LoaderManager.ILoaderCallbacks.OnLoadFinished(
               Android.Support.V4.Content.Loader loader,
               Java.Lang.Object data)
        {
            OnLoadFinished(loader, Android.Runtime.Extensions.JavaCast<Android.Database.ICursor>(data));
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment
{
    partial class ProfileFragment
    {
        partial class ProfilePictureUpload
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.Async
{
    partial class ApplozicChannelDeleteTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicChannelCreateTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicChannelLeaveMember
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicChannelNameUpdateTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicChannelRemoveMemberTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicGetMemberFromContactGroupTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class ApplozicConversationCreateTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
    partial class RemoveMemberFromContactGroupTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity
{
    partial class MobiComAttachmentSelectorActivity
    {
        partial class FileTaskAsync
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }
    partial class ConversationActivity
    {
        partial class SyncAccountStatusAsyncTask
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }
}


namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment
{
    partial class MessageInfoFragment
    {
        partial class MessageInfoAsyncTask
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }

        partial class ContactsAdapter
        {
            public override unsafe Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder(Android.Views.ViewGroup parent, int viewType)
            {
                return OnCreateMyViewHolder(parent, viewType);
            }

            public override unsafe void OnBindViewHolder(Android.Support.V7.Widget.RecyclerView.ViewHolder viewHolder, int position)
            {
                OnBindViewHolder((MyViewHolder)viewHolder, position);
            }
        }
    }

    partial class MobiComConversationFragment
    {
        partial class DownloadConversation
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }
    partial class MobiComQuickConversationFragment
    {
        partial class DownloadConversation
        {
            protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
            }
        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter
{
    partial class QuickConversationAdapter
    {
        public override unsafe Java.Lang.Object GetItem(int position)
        {
            return GetMessage(position);

        }
    }
}

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation
{
    partial class DeleteConversationAsyncTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
}