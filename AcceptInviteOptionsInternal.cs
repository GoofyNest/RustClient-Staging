internal struct AcceptInviteOptionsInternal : ISettable<AcceptInviteOptions>, IDisposable // TypeDefIndex: 9373
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref AcceptInviteOptions other) { }

	public void Set(ref Nullable<AcceptInviteOptions> other) { }

	public void Dispose() { }

}

