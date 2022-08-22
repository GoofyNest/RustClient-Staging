public class FootstepSound : MonoBehaviour, IClientComponent // TypeDefIndex: 8992
{	// Fields
	public SoundDefinition lightSound; // 0x18
	public SoundDefinition medSound; // 0x20
	public SoundDefinition hardSound; // 0x28
	private const float panAmount = 0,05;

	// Methods

	// RVA: 0x751A10 Offset: 0x750010 VA: 0x180751A10
	public void PlayFootstep(FootstepSound.Hardness hardness, bool localPlayer = False, GameObject sourceObject, bool left = False) { }

	// RVA: 0x7519F0 Offset: 0x74FFF0 VA: 0x1807519F0
	private SoundDefinition GetSound(FootstepSound.Hardness hardness) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum FootstepSound.Hardness // TypeDefIndex: 8993
{	// Fields
	public int value__; // 0x0
	public const FootstepSound.Hardness Light = 1;
	public const FootstepSound.Hardness Medium = 2;
	public const FootstepSound.Hardness Hard = 3;

}

