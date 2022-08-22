internal static class ThrowHelper // TypeDefIndex: 124
{	// Methods

	// RVA: 0x160E780 Offset: 0x160CD80 VA: 0x18160E780
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x160DF70 Offset: 0x160C570 VA: 0x18160DF70
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x160E910 Offset: 0x160CF10 VA: 0x18160E910
	internal static void ThrowArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x160E0B0 Offset: 0x160C6B0 VA: 0x18160E0B0
	private static Exception CreateArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x160E6D0 Offset: 0x160CCD0 VA: 0x18160E6D0
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x160DF00 Offset: 0x160C500 VA: 0x18160DF00
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x160E950 Offset: 0x160CF50 VA: 0x18160E950
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x160E120 Offset: 0x160C720 VA: 0x18160E120
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x160E8B0 Offset: 0x160CEB0 VA: 0x18160E8B0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x160E010 Offset: 0x160C610 VA: 0x18160E010
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x160E8F0 Offset: 0x160CEF0 VA: 0x18160E8F0
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x160EAC0 Offset: 0x160D0C0 VA: 0x18160EAC0
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x160EA00 Offset: 0x160D000 VA: 0x18160EA00
	internal static void ThrowKeyNotFoundException() { }

	// RVA: 0x160E710 Offset: 0x160CD10 VA: 0x18160E710
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x160E7C0 Offset: 0x160CDC0 VA: 0x18160E7C0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x160E990 Offset: 0x160CF90 VA: 0x18160E990
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x160EA50 Offset: 0x160D050 VA: 0x18160EA50
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4470 Offset: 0x5D2A70 VA: 0x1805D4470
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AdvancedChristmasLights.pointEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AlignedLineDrawer.LinePoint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AtmosphereVolumeRenderer.CurrentVolumeEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BaseEntity.ServerFileRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CardTableUI.KeycodeWithAction>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Cassette.LoadRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.PlayerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.ServerConvarInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.ServerUGCInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Chat.MuteEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DamageRenderer.DamageShowingRenderer>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeferredExtensionMesh.MaterialLink>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeferredMeshDecal.MaterialLink>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Demos.DemoInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CRedge>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CombineClass>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERCell>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERChildsSO>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERConnectionGUIStatus>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERLane>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERMeshCombineUtility.MeshInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERSOSection>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERSplatmap>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERTerrainChange>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERVSData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NormalPairs>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EngineDamageOverTime.RecentDamage>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EntityRef<object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ExpandedLifeStats.GenericStatDisplay>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BurstCloth.Chain>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CapsuleParams>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoneData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TabbedPanel.Tab>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Output.Entry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RCon.BannedAddresses>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkeletonDefinition.Bone>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Tick.Entry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderInfo.RendererInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WeightedStringList.Container>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FoliageGridMeshData.FoliageVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Option>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GameStat.Stat>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Gibbable.OverrideMesh>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IconSkinPicker.SkinButtonSetup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ImageStorageEntity.ImageRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InvokeAction>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ItemSkinDirectory.Skin>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyframeView.UIKeyframeValue>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<LocalClock.TimedEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MagnetCrane.MagnetCraneSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapView.MapMarkerCluster>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapView.SleepingBagCluster>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SevenBitNumber>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshColliderInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshColliderLookup.LookupEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshRendererInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshRendererLookup.LookupEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MidiConvar.KnobBinding>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MidiConvar.NoteBinding>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SqliteKeyReader.KeyInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<JsonPosition>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ParticleSystemContainer.ParticleSystemGroup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PathFinder.Point>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PetCommandList.PetCommandDesc>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonuments.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsOffshore.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsRailside.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsRoadside.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerItemRecipe.Ingredient>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerItemRecipe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ProjectileWeaponMod.Modifier>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotFloatKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotParentKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotQuaternionKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotVectorKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<VectorData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeEx.CubemapSkyboxVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeEx.RenderListEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WaypointSet.Waypoint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TransformSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimelineEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Option>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TickRenderer.Tick>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ServerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkinnedMultiMesh.Part>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubmarineSonar.SonarBlip>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SpawnIndividual>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SpecialPurposeCamera.RenderEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SteamNewsSource.Story>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Achievement>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryDefId>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MatchMakingKeyValuePair>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ServerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Dispatch.Callback>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Friend>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryItem.Amount>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryItem>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryRecipe.Ingredient>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryRecipe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubsurfaceProfileTexture.SubsurfaceProfileEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SynchronizedClock.TimedEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<bool>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<byte>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<char>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DictionaryEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<DateTime, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, float>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, Color>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<uint, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTime>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTimeOffset>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Decimal>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EventProvider.SessionInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<double>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Guid>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<short>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<int>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int32Enum>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<long>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<sbyte>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<float>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeSpan>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ushort>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<uint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ulong>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangePositionInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TickInterpolator.Segment>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TraceInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TrainCar.TrainCarSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildMarkup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildSource>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BeforeRenderHelper.OrderBlock>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color32>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastResult>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit2D>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Rect>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderTargetIdentifier>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Resolution>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GlyphRect>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TreeInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UICharInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FocusController.FocusedElement>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UILineInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UnitySynchronizationContext.WorkRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector4>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2i>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ViewModelDrawEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WindZoneExManager.CurrentZoneEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WorldSplineData.LUTEntry.LUTPoint>
	|
	|-RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<object>
	*/

	// RVA: 0x160E170 Offset: 0x160C770 VA: 0x18160E170
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x160E360 Offset: 0x160C960 VA: 0x18160E360
	internal static string GetResourceName(ExceptionResource resource) { }

}

internal static class ThrowHelper // TypeDefIndex: 6726
{
// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 6726
	// Methods

	// RVA: 0x231B810 Offset: 0x2319E10 VA: 0x18231B810
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x231B6B0 Offset: 0x2319CB0 VA: 0x18231B6B0
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x231B790 Offset: 0x2319D90 VA: 0x18231B790
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x231B400 Offset: 0x2319A00 VA: 0x18231B400
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x231B750 Offset: 0x2319D50 VA: 0x18231B750
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x231B330 Offset: 0x2319930 VA: 0x18231B330
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x231B850 Offset: 0x2319E50 VA: 0x18231B850
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x231B700 Offset: 0x2319D00 VA: 0x18231B700
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x231B7D0 Offset: 0x2319DD0 VA: 0x18231B7D0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x231B610 Offset: 0x2319C10 VA: 0x18231B610
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

}

internal static class ThrowHelper // TypeDefIndex: 7083
{	// Methods

	// RVA: 0x2312FF0 Offset: 0x23115F0 VA: 0x182312FF0
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x2313030 Offset: 0x2311630 VA: 0x182313030
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x2312F30 Offset: 0x2311530 VA: 0x182312F30
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x2312F90 Offset: 0x2311590 VA: 0x182312F90
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x2312EB0 Offset: 0x23114B0 VA: 0x182312EB0
	private static string GetArgumentName(ExceptionArgument argument) { }

}

