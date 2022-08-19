internal sealed class VisualTreeUpdater // TypeDefIndex: 4618
{	// Fields
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x10

	// Methods

	// RVA: 0x22F79D0 Offset: 0x22F5FD0 VA: 0x1822F79D0
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x22F78A0 Offset: 0x22F5EA0 VA: 0x1822F78A0
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4619
{	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public IVisualTreeUpdater get_Item(int index) { }

}

