public sealed class OnQueryAgeGateCallback : MulticastDelegate // TypeDefIndex: 9342
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryAgeGateCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryAgeGateCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryAgeGateCallbackInfo data, IAsyncResult result) { }

}

