internal struct HideFriendsOptionsInternal : ISettable<HideFriendsOptions>, IDisposable // TypeDefIndex: 8299
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref HideFriendsOptions other) { }

	public void Set(ref Nullable<HideFriendsOptions> other) { }

	public void Dispose() { }

}

