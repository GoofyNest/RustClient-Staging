internal sealed class OnLogoutCallbackInternal : MulticastDelegate // TypeDefIndex: 9645
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LogoutCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref LogoutCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LogoutCallbackInfoInternal data, IAsyncResult result) { }

}

