public sealed class WaitCallback : MulticastDelegate // TypeDefIndex: 806
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object state) { }

public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

