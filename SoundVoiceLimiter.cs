public class SoundVoiceLimiter : MonoBehaviour, IClientComponent // TypeDefIndex: 9045
{	// Fields
	public int maxSimultaneousSounds; // 0x18
	private List<Sound> sounds; // 0x20

	// Methods

	// RVA: 0xA7D5E0 Offset: 0xA7BBE0 VA: 0x180A7D5E0
	public void EnforceSoundLimit() { }

	// RVA: 0xA7D580 Offset: 0xA7BB80 VA: 0x180A7D580
	public void AddSound(Sound sound) { }

	// RVA: 0xA7D7E0 Offset: 0xA7BDE0 VA: 0x180A7D7E0
	public void RemoveSound(Sound sound) { }

	// RVA: 0xA7D840 Offset: 0xA7BE40 VA: 0x180A7D840
	public void .ctor() { }

}

