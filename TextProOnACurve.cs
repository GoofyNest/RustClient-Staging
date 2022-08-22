public abstract class TextProOnACurve : MonoBehaviour // TypeDefIndex: 7122
{	// Fields
	private TMP_Text m_TextComponent; // 0x18

	// Methods

	// RVA: 0x22C8D00 Offset: 0x22C7300 VA: 0x1822C8D00
	private void Awake() { }

	// RVA: 0x22C95F0 Offset: 0x22C7BF0 VA: 0x1822C95F0
	private void OnEnable() { }

	// RVA: 0x22C8D60 Offset: 0x22C7360 VA: 0x1822C8D60
	public void ForceUpdate() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool ParametersHaveChanged();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx);

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

