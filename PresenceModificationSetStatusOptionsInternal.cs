internal struct PresenceModificationSetStatusOptionsInternal : ISettable<PresenceModificationSetStatusOptions>, IDisposable // TypeDefIndex: 8860
{
	private int m_ApiVersion;
	private Status m_Status;

	public Status Status { set; }


	public void set_Status(Status value) { }

	public void Set(ref PresenceModificationSetStatusOptions other) { }

	public void Set(ref Nullable<PresenceModificationSetStatusOptions> other) { }

	public void Dispose() { }

}

