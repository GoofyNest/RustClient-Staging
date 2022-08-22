public class Megaphone : HeldEntity // TypeDefIndex: 8604
{	[HeaderAttribute] // RVA: 0xB04C0 Offset: 0xAF8C0 VA: 0x1800B04C0
	public VoiceProcessor voiceProcessor; // 0x1F8
	public float VoiceDamageMinFrequency; // 0x200
	public float VoiceDamageAmount; // 0x204
	public AudioSource VoiceSource; // 0x208
	public SoundDefinition StartBroadcastingSfx; // 0x210
	public SoundDefinition StopBroadcastingSfx; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static float <MegaphoneVoiceRange>k__BackingField; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool IgnorePushToTalk; // 0x4
	private static int BroadcastBoolAnim; // 0x8
	private float talkingLayerWeight; // 0x220

	[ReplicatedVar] // RVA: 0xB07E0 Offset: 0xAFBE0 VA: 0x1800B07E0
	public static float MegaphoneVoiceRange { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static float get_MegaphoneVoiceRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void set_MegaphoneVoiceRange(float value) { }

	public bool Receive(byte[] data) { }

	public override void OnInput() { }

	private void Update() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

