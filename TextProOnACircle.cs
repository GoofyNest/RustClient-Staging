public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
{
// Namespace: 
internal class <Module> // TypeDefIndex: 7120

// Namespace: ntw.CurvedTextMeshPro
[ExecuteInEditMode] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
	// Fields
	[SerializeField] // RVA: 0x7FFE0 Offset: 0x7F3E0 VA: 0x18007FFE0
	[TooltipAttribute] // RVA: 0x7FFE0 Offset: 0x7F3E0 VA: 0x18007FFE0
	private float m_radius; // 0x20
	[TooltipAttribute] // RVA: 0x80150 Offset: 0x7F550 VA: 0x180080150
	public float m_arcDegrees; // 0x24
	[SerializeField] // RVA: 0x801F0 Offset: 0x7F5F0 VA: 0x1800801F0
	[TooltipAttribute] // RVA: 0x801F0 Offset: 0x7F5F0 VA: 0x1800801F0
	private float m_angularOffset; // 0x28
	private float m_oldRadius; // 0x2C
	private float m_oldArcDegrees; // 0x30
	private float m_oldAngularOffset; // 0x34

	// Methods

	// RVA: 0x22C8440 Offset: 0x22C6A40 VA: 0x1822C8440 Slot: 4
	protected override bool ParametersHaveChanged() { }

	// RVA: 0x22C8190 Offset: 0x22C6790 VA: 0x1822C8190 Slot: 5
	protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx) { }

	// RVA: 0x22C84A0 Offset: 0x22C6AA0 VA: 0x1822C84A0
	public void .ctor() { }

}

