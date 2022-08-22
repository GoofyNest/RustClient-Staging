internal sealed class VisualTreeUpdater // TypeDefIndex: 4618
{	// Fields
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x10

	// Methods

	// RVA: 0x22F82F0 Offset: 0x22F68F0 VA: 0x1822F82F0
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x22F81C0 Offset: 0x22F67C0 VA: 0x1822F81C0
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 4619
{	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	public IVisualTreeUpdater get_Item(int index) { }

}

