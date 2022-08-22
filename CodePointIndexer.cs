internal class CodePointIndexer // TypeDefIndex: 29
{	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x163C8E0 Offset: 0x163AEE0 VA: 0x18163C8E0
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x163C860 Offset: 0x163AE60 VA: 0x18163C860
	public int ToIndex(int cp) { }

}

internal struct CodePointIndexer.TableRange // TypeDefIndex: 30
{	// Fields
	public readonly int Start; // 0x0
	public readonly int End; // 0x4
	public readonly int Count; // 0x8
	public readonly int IndexStart; // 0xC
	public readonly int IndexEnd; // 0x10

	// Methods

	// RVA: 0x1F6C40 Offset: 0x1F6040 VA: 0x1801F6C40
	public void .ctor(int start, int end, int indexStart) { }

}

