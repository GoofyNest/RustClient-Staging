internal struct UpdateModOptionsInternal : ISettable<UpdateModOptions>, IDisposable // TypeDefIndex: 9040
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Mod; 

	public EpicAccountId LocalUserId { set; }
	public Nullable<ModIdentifier> Mod { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_Mod(Nullable<ModIdentifier> value) { }

	public void Set(ref UpdateModOptions other) { }

	public void Set(ref Nullable<UpdateModOptions> other) { }

	public void Dispose() { }

}

