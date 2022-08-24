public class X509Chain : IDisposable // TypeDefIndex: 2822
{
	private X509ChainImpl impl; 

internal X509ChainImpl Impl { get; }
public X509ChainPolicy ChainPolicy { get; set; }
public X509ChainStatus[] ChainStatus { get; }


internal X509ChainImpl get_Impl() { }

public void .ctor() { }

public void .ctor(bool useMachineContext) { }

public X509ChainPolicy get_ChainPolicy() { }

public void set_ChainPolicy(X509ChainPolicy value) { }

public X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] 
public bool Build(X509Certificate2 certificate) { }

public static X509Chain Create() { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

protected override void Finalize() { }

}

