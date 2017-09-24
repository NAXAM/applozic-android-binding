namespace Com.Applozic.Mobicommons.Json
{
    partial class ArrayAdapter
    {
        public override unsafe void Write(GoogleGson.Stream.JsonWriter writer, Java.Lang.Object value)
        {
            var list = Android.Runtime.JavaList.FromJniHandle(value.Handle, Android.Runtime.JniHandleOwnership.DoNotTransfer);

            Write(writer, list);
        }

        public override unsafe Java.Lang.Object Read(global::GoogleGson.Stream.JsonReader reader)
        {
            var list = ReadList(reader);
            var handle = Android.Runtime.JavaList.ToLocalJniHandle(list);

            try
			{
                return new Java.Lang.Object(handle, Android.Runtime.JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                Android.Runtime.JNIEnv.DeleteLocalRef(handle);
            }
        }
    }
}