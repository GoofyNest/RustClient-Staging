public sealed class OnSendLobbyNativeInviteRequestedCallback : MulticastDelegate // TypeDefIndex: 9202
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SendLobbyNativeInviteRequestedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SendLobbyNativeInviteRequestedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SendLobbyNativeInviteRequestedCallbackInfo data, IAsyncResult result) { }

}

