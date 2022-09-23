public sealed class OnUpdateSendingVolumeCallback : MulticastDelegate // TypeDefIndex: 8684
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateSendingVolumeCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateSendingVolumeCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateSendingVolumeCallbackInfo data, IAsyncResult result) { }

}

