internal sealed class OnPeerActionRequiredCallbackInternal : MulticastDelegate // TypeDefIndex: 9831
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientActionRequiredCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfoInternal data, IAsyncResult result) { }

}

