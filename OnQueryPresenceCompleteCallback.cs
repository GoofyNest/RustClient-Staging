public sealed class OnQueryPresenceCompleteCallback : MulticastDelegate // TypeDefIndex: 8795
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryPresenceCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryPresenceCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryPresenceCallbackInfo data, IAsyncResult result) { }

}

