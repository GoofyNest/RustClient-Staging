public sealed class OnQueryUserInfoCallback : MulticastDelegate // TypeDefIndex: 8317
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryUserInfoCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryUserInfoCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryUserInfoCallbackInfo data, IAsyncResult result) { }

}

