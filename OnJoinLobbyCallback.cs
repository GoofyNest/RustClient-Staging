public sealed class OnJoinLobbyCallback : MulticastDelegate // TypeDefIndex: 9208
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinLobbyCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinLobbyCallbackInfo data, IAsyncResult result) { }

}

