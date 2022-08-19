public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
{
// Namespace: 
internal class <Module> // TypeDefIndex: 7120

// Namespace: ntw.CurvedTextMeshPro
[ExecuteInEditMode] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
	// Fields
	[SerializeField] // RVA: 0x7FF20 Offset: 0x7F320 VA: 0x18007FF20
	[TooltipAttribute] // RVA: 0x7FF20 Offset: 0x7F320 VA: 0x18007FF20
	private float m_radius; // 0x20
	[TooltipAttribute] // RVA: 0x80090 Offset: 0x7F490 VA: 0x180080090
	public float m_arcDegrees; // 0x24
	[SerializeField] // RVA: 0x80130 Offset: 0x7F530 VA: 0x180080130
	[TooltipAttribute] // RVA: 0x80130 Offset: 0x7F530 VA: 0x180080130
	private float m_angularOffset; // 0x28
	private float m_oldRadius; // 0x2C
	private float m_oldArcDegrees; // 0x30
	private float m_oldAngularOffset; // 0x34

	// Methods

	// RVA: 0x22C8340 Offset: 0x22C6940 VA: 0x1822C8340 Slot: 4
	protected override bool ParametersHaveChanged() { }

	// RVA: 0x22C8090 Offset: 0x22C6690 VA: 0x1822C8090 Slot: 5
	protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx) { }

	// RVA: 0x22C83A0 Offset: 0x22C69A0 VA: 0x1822C83A0
	public void .ctor() { }

}

