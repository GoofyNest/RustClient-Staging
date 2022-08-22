internal sealed class VisualTreeUpdater // TypeDefIndex: 4618
{	// Fields
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x10

	// Methods

	// RVA: 0x22F7AD0 Offset: 0x22F60D0 VA: 0x1822F7AD0
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x22F79A0 Offset: 0x22F5FA0 VA: 0x1822F79A0
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4619
{	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	public IVisualTreeUpdater get_Item(int index) { }

}

