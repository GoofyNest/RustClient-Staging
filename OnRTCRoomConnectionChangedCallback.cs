public sealed class OnRTCRoomConnectionChangedCallback : MulticastDelegate // TypeDefIndex: 9231
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref RTCRoomConnectionChangedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref RTCRoomConnectionChangedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref RTCRoomConnectionChangedCallbackInfo data, IAsyncResult result) { }

}

