public class ReadingSettings // TypeDefIndex: 7601
{	// Fields
	private UnexpectedTrackChunksCountPolicy _unexpectedTrackChunksCountPolicy; // 0x10
	private ExtraTrackChunkPolicy _extraTrackChunkPolicy; // 0x14
	private UnknownChunkIdPolicy _unknownChunkIdPolicy; // 0x15
	private MissedEndOfTrackPolicy _missedEndOfTrackPolicy; // 0x16
	private SilentNoteOnPolicy _silentNoteOnPolicy; // 0x17
	private InvalidChunkSizePolicy _invalidChunkSizePolicy; // 0x18
	private UnknownFileFormatPolicy _unknownFileFormatPolicy; // 0x1C
	private UnknownChannelEventPolicy _unknownChannelEventPolicy; // 0x20
	private InvalidChannelEventParameterValuePolicy _invalidChannelEventParameterValuePolicy; // 0x24
	private InvalidMetaEventParameterValuePolicy _invalidMetaEventParameterValuePolicy; // 0x28
	private InvalidSystemCommonEventParameterValuePolicy _invalidSystemCommonEventParameterValuePolicy; // 0x2C
	private NotEnoughBytesPolicy _notEnoughBytesPolicy; // 0x30
	private NoHeaderChunkPolicy _noHeaderChunkPolicy; // 0x34
	private ZeroLengthDataPolicy _zeroLengthDataPolicy; // 0x38
	private EndOfTrackStoringPolicy _endOfTrackStoringPolicy; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UnknownChannelEventCallback <UnknownChannelEventCallback>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ChunkTypesCollection <CustomChunkTypes>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventTypesCollection <CustomMetaEventTypes>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Encoding <TextEncoding>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DecodeTextCallback <DecodeTextCallback>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ReaderSettings <ReaderSettings>k__BackingField; // 0x68

	// Properties
	public UnexpectedTrackChunksCountPolicy UnexpectedTrackChunksCountPolicy { get; }
	public ExtraTrackChunkPolicy ExtraTrackChunkPolicy { get; }
	public UnknownChunkIdPolicy UnknownChunkIdPolicy { get; }
	public MissedEndOfTrackPolicy MissedEndOfTrackPolicy { get; }
	public SilentNoteOnPolicy SilentNoteOnPolicy { get; }
	public InvalidChunkSizePolicy InvalidChunkSizePolicy { get; }
	public UnknownFileFormatPolicy UnknownFileFormatPolicy { get; }
	public UnknownChannelEventPolicy UnknownChannelEventPolicy { get; }
	public UnknownChannelEventCallback UnknownChannelEventCallback { get; }
	public InvalidChannelEventParameterValuePolicy InvalidChannelEventParameterValuePolicy { get; }
	public InvalidMetaEventParameterValuePolicy InvalidMetaEventParameterValuePolicy { get; }
	public InvalidSystemCommonEventParameterValuePolicy InvalidSystemCommonEventParameterValuePolicy { get; }
	public NotEnoughBytesPolicy NotEnoughBytesPolicy { get; }
	public NoHeaderChunkPolicy NoHeaderChunkPolicy { get; }
	public ChunkTypesCollection CustomChunkTypes { get; }
	public EventTypesCollection CustomMetaEventTypes { get; }
	public Encoding TextEncoding { get; }
	public DecodeTextCallback DecodeTextCallback { get; }
	public ZeroLengthDataPolicy ZeroLengthDataPolicy { get; }
	public EndOfTrackStoringPolicy EndOfTrackStoringPolicy { get; }
	public ReaderSettings ReaderSettings { get; set; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public UnexpectedTrackChunksCountPolicy get_UnexpectedTrackChunksCountPolicy() { }

	// RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	public ExtraTrackChunkPolicy get_ExtraTrackChunkPolicy() { }

	// RVA: 0x13A53D0 Offset: 0x13A39D0 VA: 0x1813A53D0
	public UnknownChunkIdPolicy get_UnknownChunkIdPolicy() { }

	// RVA: 0x13A53B0 Offset: 0x13A39B0 VA: 0x1813A53B0
	public MissedEndOfTrackPolicy get_MissedEndOfTrackPolicy() { }

	// RVA: 0x13A53C0 Offset: 0x13A39C0 VA: 0x1813A53C0
	public SilentNoteOnPolicy get_SilentNoteOnPolicy() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public InvalidChunkSizePolicy get_InvalidChunkSizePolicy() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public UnknownFileFormatPolicy get_UnknownFileFormatPolicy() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public UnknownChannelEventPolicy get_UnknownChannelEventPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public UnknownChannelEventCallback get_UnknownChannelEventCallback() { }

	// RVA: 0x774690 Offset: 0x772C90 VA: 0x180774690
	public InvalidChannelEventParameterValuePolicy get_InvalidChannelEventParameterValuePolicy() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public InvalidMetaEventParameterValuePolicy get_InvalidMetaEventParameterValuePolicy() { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public InvalidSystemCommonEventParameterValuePolicy get_InvalidSystemCommonEventParameterValuePolicy() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public NotEnoughBytesPolicy get_NotEnoughBytesPolicy() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public NoHeaderChunkPolicy get_NoHeaderChunkPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public ChunkTypesCollection get_CustomChunkTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public EventTypesCollection get_CustomMetaEventTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Encoding get_TextEncoding() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public DecodeTextCallback get_DecodeTextCallback() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public ZeroLengthDataPolicy get_ZeroLengthDataPolicy() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public EndOfTrackStoringPolicy get_EndOfTrackStoringPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public ReaderSettings get_ReaderSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_ReaderSettings(ReaderSettings value) { }

	// RVA: 0x13A5310 Offset: 0x13A3910 VA: 0x1813A5310
	public void .ctor() { }

}

