public sealed class OnCustomInviteAcceptedCallback : MulticastDelegate // TypeDefIndex: 9520
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnCustomInviteAcceptedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnCustomInviteAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnCustomInviteAcceptedCallbackInfo data, IAsyncResult result) { }

}

