public class Megaphone : HeldEntity // TypeDefIndex: 8604
{	[HeaderAttribute] // RVA: 0xB05D0 Offset: 0xAF9D0 VA: 0x1800B05D0
	public VoiceProcessor voiceProcessor; // 0x1F8
	public float VoiceDamageMinFrequency; // 0x200
	public float VoiceDamageAmount; // 0x204
	public AudioSource VoiceSource; // 0x208
	public SoundDefinition StartBroadcastingSfx; // 0x210
	public SoundDefinition StopBroadcastingSfx; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static float <MegaphoneVoiceRange>k__BackingField; // 0x0
	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static bool IgnorePushToTalk; // 0x4
	private static int BroadcastBoolAnim; // 0x8
	private float talkingLayerWeight; // 0x220

	[ReplicatedVar] // RVA: 0xB08C0 Offset: 0xAFCC0 VA: 0x1800B08C0
	public static float MegaphoneVoiceRange { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static float get_MegaphoneVoiceRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void set_MegaphoneVoiceRange(float value) { }

	public bool Receive(byte[] data) { }

	public override void OnInput() { }

	private void Update() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

