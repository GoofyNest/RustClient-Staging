internal class CodePointIndexer // TypeDefIndex: 29
{	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x1629C00 Offset: 0x1628200 VA: 0x181629C00
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x1629B80 Offset: 0x1628180 VA: 0x181629B80
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

	// RVA: 0x1F5A90 Offset: 0x1F4E90 VA: 0x1801F5A90
	public void .ctor(int start, int end, int indexStart) { }

}

