public class MidiDriver // TypeDefIndex: 7642
{	// Fields
	private MidiDriver.ChannelState[] _channelArray; // 0x10
	private int _lastFrame; // 0x18
	private bool enabled; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiDriver.NoteOnDelegate <noteOnDelegate>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiDriver.NoteOffDelegate <noteOffDelegate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiDriver.KnobDelegate <knobDelegate>k__BackingField; // 0x30
	private static MidiDriver _instance; // 0x0

	// Properties
	public MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public MidiDriver.KnobDelegate knobDelegate { get; set; }
	public static MidiDriver Instance { get; }

	// Methods

	// RVA: 0x23171B0 Offset: 0x23157B0 VA: 0x1823171B0
	public float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317040 Offset: 0x2315640 VA: 0x182317040
	public bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317100 Offset: 0x2315700 VA: 0x182317100
	public bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2317290 Offset: 0x2315890 VA: 0x182317290
	public int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x2317380 Offset: 0x2315980 VA: 0x182317380
	public float GetKnob(MidiChannel channel, int knobNumber, float defaultValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public MidiDriver.KnobDelegate get_knobDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x23179F0 Offset: 0x2315FF0 VA: 0x1823179F0
	private void .ctor() { }

	// RVA: 0x79C6D0 Offset: 0x79ACD0 VA: 0x18079C6D0
	public void ToggleEnabled(bool state) { }

	// RVA: 0x2316F40 Offset: 0x2315540 VA: 0x182316F40
	public void ClearOutstandingData() { }

	// RVA: 0x2317470 Offset: 0x2315A70 VA: 0x182317470
	private void UpdateIfNeeded() { }

	// RVA: 0x23174B0 Offset: 0x2315AB0 VA: 0x1823174B0
	public void Update() { }

	// RVA: 0x2316FD0 Offset: 0x23155D0 VA: 0x182316FD0
	public static extern ulong DequeueIncomingData() { }

	// RVA: 0x2317B70 Offset: 0x2316170 VA: 0x182317B70
	public static MidiDriver get_Instance() { }

}

private class MidiDriver.ChannelState // TypeDefIndex: 7643
{	// Fields
	public float[] _noteArray; // 0x10
	public Dictionary<int, float> _knobMap; // 0x18

	// Methods

	// RVA: 0x2316BB0 Offset: 0x23151B0 VA: 0x182316BB0
	public void .ctor() { }

}

public sealed class MidiDriver.NoteOnDelegate : MulticastDelegate // TypeDefIndex: 7644
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2316CE0 Offset: 0x23152E0 VA: 0x182316CE0 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x23183D0 Offset: 0x23169D0 VA: 0x1823183D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, float velocity, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.NoteOffDelegate : MulticastDelegate // TypeDefIndex: 7645
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AA4420 Offset: 0x1AA2A20 VA: 0x181AA4420 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note) { }

	// RVA: 0x2318340 Offset: 0x2316940 VA: 0x182318340 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.KnobDelegate : MulticastDelegate // TypeDefIndex: 7646
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2316CE0 Offset: 0x23152E0 VA: 0x182316CE0 Slot: 12
	public virtual void Invoke(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x2316C40 Offset: 0x2315240 VA: 0x182316C40 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int knobNumber, float knobValue, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

