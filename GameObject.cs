public sealed class GameObject : Object // TypeDefIndex: 3515
{
// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0xBBF90 Offset: 0xBB390 VA: 0x1800BBF90
[ExcludeFromPresetAttribute] // RVA: 0xBBF90 Offset: 0xBB390 VA: 0x1800BBF90
[NativeHeaderAttribute] // RVA: 0xBBF90 Offset: 0xBB390 VA: 0x1800BBF90
public sealed class GameObject : Object // TypeDefIndex: 3515
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	public string tag { get; set; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xBC2B0 Offset: 0xBB6B0 VA: 0x1800BC2B0
	// RVA: 0x182AE30 Offset: 0x1829430 VA: 0x18182AE30
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3E20 Offset: 0x15A2420 VA: 0x1815A3E20
	|-GameObject.GetComponent<AdminExistingSellOrder>
	|-GameObject.GetComponent<AmbienceEmitter>
	|-GameObject.GetComponent<AttackEntity>
	|-GameObject.GetComponent<BaseBulb>
	|-GameObject.GetComponent<BaseCollision>
	|-GameObject.GetComponent<BaseEntity>
	|-GameObject.GetComponent<BaseMelee>
	|-GameObject.GetComponent<BaseMeshPaintable>
	|-GameObject.GetComponent<BaseMovement>
	|-GameObject.GetComponent<BaseProjectile>
	|-GameObject.GetComponent<BaseViewModel>
	|-GameObject.GetComponent<BlueprintButton>
	|-GameObject.GetComponent<BobberPreview>
	|-GameObject.GetComponent<BranchConfig>
	|-GameObject.GetComponent<BuildingPrivlidge>
	|-GameObject.GetComponent<CardTableUI>
	|-GameObject.GetComponent<ChangeSignText>
	|-GameObject.GetComponent<ChatEntry>
	|-GameObject.GetComponent<ClientIOLine>
	|-GameObject.GetComponent<ColliderInfo>
	|-GameObject.GetComponent<CommunityEntity.FadeOut>
	|-GameObject.GetComponent<ComputerMenu>
	|-GameObject.GetComponent<ConditionalGibbable>
	|-GameObject.GetComponent<ConstructionSkin>
	|-GameObject.GetComponent<CounterConfig>
	|-GameObject.GetComponent<CraftingQueueIcon>
	|-GameObject.GetComponent<CullingVolume>
	|-GameObject.GetComponent<DemoItem>
	|-GameObject.GetComponent<DemoShotEntry>
	|-GameObject.GetComponent<DemoShotListFolderWidget>
	|-GameObject.GetComponent<DropMe>
	|-GameObject.GetComponent<ERSurfaceScript>
	|-GameObject.GetComponent<ERCrossingPrefabs>
	|-GameObject.GetComponent<ERCrossings>
	|-GameObject.GetComponent<ERIConnector>
	|-GameObject.GetComponent<ERModularBase>
	|-GameObject.GetComponent<ERModularRoad>
	|-GameObject.GetComponent<ERRoundabouts>
	|-GameObject.GetComponent<ERSideObjectInstance>
	|-GameObject.GetComponent<ERSideObjectLog>
	|-GameObject.GetComponent<ERTerrain>
	|-GameObject.GetComponent<EffectParentToWeaponBone>
	|-GameObject.GetComponent<EntityDebug>
	|-GameObject.GetComponent<EnvironmentFish>
	|-GameObject.GetComponent<EnvironmentVolume>
	|-GameObject.GetComponent<SkeletonSkin>
	|-GameObject.GetComponent<VirtualScroll.IDataSource>
	|-GameObject.GetComponent<FavouriteRadioStation>
	|-GameObject.GetComponent<FireworkShell>
	|-GameObject.GetComponent<FoliageGridBatch>
	|-GameObject.GetComponent<FootstepSound>
	|-GameObject.GetComponent<FrequencyConfig>
	|-GameObject.GetComponent<Gib>
	|-GameObject.GetComponent<Gibbable>
	|-GameObject.GetComponent<GrowableEntity>
	|-GameObject.GetComponent<HeldEntity>
	|-GameObject.GetComponent<IEffectRecycle>
	|-GameObject.GetComponent<INotifyLOD>
	|-GameObject.GetComponent<IOEntity>
	|-GameObject.GetComponent<IconSkin>
	|-GameObject.GetComponent<IdentifierConfig>
	|-GameObject.GetComponent<ImageEffectComposite>
	|-GameObject.GetComponent<ImageRenderController>
	|-GameObject.GetComponent<ImpostorShadows>
	|-GameObject.GetComponent<IronSightOverride>
	|-GameObject.GetComponent<ItemBlueprint>
	|-GameObject.GetComponent<ItemDefinition>
	|-GameObject.GetComponent<ItemOptionButton>
	|-GameObject.GetComponent<ItemPickupNotice>
	|-GameObject.GetComponent<ItemStoreCartItem>
	|-GameObject.GetComponent<ItemStoreItem>
	|-GameObject.GetComponent<KeyCodeEntry>
	|-GameObject.GetComponent<KeyframeWidget>
	|-GameObject.GetComponent<LifeInfographicStatDynamicRow>
	|-GameObject.GetComponent<LifeInfographicStatWeapon>
	|-GameObject.GetComponent<MainCamera>
	|-GameObject.GetComponent<MapLayerRenderer>
	|-GameObject.GetComponent<MaterialSwap>
	|-GameObject.GetComponent<MaxSpawnDistance>
	|-GameObject.GetComponent<MedicalTool>
	|-GameObject.GetComponent<MeshRendererBatch>
	|-GameObject.GetComponent<MissionMapMarker>
	|-GameObject.GetComponent<Model>
	|-GameObject.GetComponent<MonumentMarker>
	|-GameObject.GetComponent<NeedsCursor>
	|-GameObject.GetComponent<NeedsKeyboard>
	|-GameObject.GetComponent<ObjectMotionVectorFix>
	|-GameObject.GetComponent<PhoneDialler>
	|-GameObject.GetComponent<PhoneDirectoryEntry>
	|-GameObject.GetComponent<PhysicsEffects>
	|-GameObject.GetComponent<PickAFriend>
	|-GameObject.GetComponent<PieOption>
	|-GameObject.GetComponent<PlantSkin>
	|-GameObject.GetComponent<PlayerModel>
	|-GameObject.GetComponent<PlayerWalkMovement>
	|-GameObject.GetComponent<PointOfInterestMapMarker>
	|-GameObject.GetComponent<Poolable>
	|-GameObject.GetComponent<PowerLineWireConnectionHelper>
	|-GameObject.GetComponent<PrefabParameters>
	|-GameObject.GetComponent<Projectile>
	|-GameObject.GetComponent<ProjectileWeaponMod>
	|-GameObject.GetComponent<QuickCraftButton>
	|-GameObject.GetComponent<RCBookmarkEntry>
	|-GameObject.GetComponent<RadioDialog>
	|-GameObject.GetComponent<Ragdoll>
	|-GameObject.GetComponent<RecordingBars>
	|-GameObject.GetComponent<RenameSleepingBag>
	|-GameObject.GetComponent<ReskinEffect>
	|-GameObject.GetComponent<RidableHorse>
	|-GameObject.GetComponent<IEntity>
	|-GameObject.GetComponent<PropRenderer>
	|-GameObject.GetComponent<FileDialog>
	|-GameObject.GetComponent<FileListElement>
	|-GameObject.GetComponent<RustButton>
	|-GameObject.GetComponent<RustText>
	|-GameObject.GetComponent<ServerAdminServerInfo>
	|-GameObject.GetComponent<SteamInventoryItem>
	|-GameObject.GetComponent<WorkshopItemButton>
	|-GameObject.GetComponent<WorkshopSkin>
	|-GameObject.GetComponent<SellOrderEntry>
	|-GameObject.GetComponent<ServerBrowserItem>
	|-GameObject.GetComponent<ServerHistoryItem>
	|-GameObject.GetComponent<ServerProjectile>
	|-GameObject.GetComponent<SetupAppNotification>
	|-GameObject.GetComponent<SlotMachinePayoutWidget>
	|-GameObject.GetComponent<Sound>
	|-GameObject.GetComponent<SoundLightDialog>
	|-GameObject.GetComponent<SoundPlayer>
	|-GameObject.GetComponent<SoundSource>
	|-GameObject.GetComponent<SprayCanSkinSelect>
	|-GameObject.GetComponent<SteamUserButton>
	|-GameObject.GetComponent<TMP_InputField>
	|-GameObject.GetComponent<TMP_SubMesh>
	|-GameObject.GetComponent<TMP_Text>
	|-GameObject.GetComponent<TerrainGenerator>
	|-GameObject.GetComponent<TerrainMeta>
	|-GameObject.GetComponent<ThrownWeapon>
	|-GameObject.GetComponent<TimedExplosive>
	|-GameObject.GetComponent<TimerConfig>
	|-GameObject.GetComponent<ToggleHUDLayer>
	|-GameObject.GetComponent<UIChatPopup>
	|-GameObject.GetComponent<UIEscapeCapture>
	|-GameObject.GetComponent<UIFireworkDesigner>
	|-GameObject.GetComponent<UIFireworkStar>
	|-GameObject.GetComponent<UIMapGenericRadius>
	|-GameObject.GetComponent<UIMapVendingMachineMarker>
	|-GameObject.GetComponent<UIMapVendingMachineMarkerCluster>
	|-GameObject.GetComponent<UIMarketSearchStore>
	|-GameObject.GetComponent<UIMixingTableItem>
	|-GameObject.GetComponent<UIPaintableImage>
	|-GameObject.GetComponent<UnderwearIcon>
	|-GameObject.GetComponent<NavMeshAgent>
	|-GameObject.GetComponent<NavMeshObstacle>
	|-GameObject.GetComponent<AudioSource>
	|-GameObject.GetComponent<BoxCollider>
	|-GameObject.GetComponent<Camera>
	|-GameObject.GetComponent<Canvas>
	|-GameObject.GetComponent<CanvasGroup>
	|-GameObject.GetComponent<CanvasRenderer>
	|-GameObject.GetComponent<Collider>
	|-GameObject.GetComponent<LODGroup>
	|-GameObject.GetComponent<Light>
	|-GameObject.GetComponent<MeshCollider>
	|-GameObject.GetComponent<MeshFilter>
	|-GameObject.GetComponent<MeshRenderer>
	|-GameObject.GetComponent<ParticleSystem>
	|-GameObject.GetComponent<RectTransform>
	|-GameObject.GetComponent<ReflectionProbe>
	|-GameObject.GetComponent<Renderer>
	|-GameObject.GetComponent<Rigidbody>
	|-GameObject.GetComponent<SpriteRenderer>
	|-GameObject.GetComponent<Terrain>
	|-GameObject.GetComponent<TerrainCollider>
	|-GameObject.GetComponent<Transform>
	|-GameObject.GetComponent<Button>
	|-GameObject.GetComponent<Dropdown>
	|-GameObject.GetComponent<Image>
	|-GameObject.GetComponent<InputField>
	|-GameObject.GetComponent<Mask>
	|-GameObject.GetComponent<ScrollRect>
	|-GameObject.GetComponent<Scrollbar>
	|-GameObject.GetComponent<Slider>
	|-GameObject.GetComponent<Text>
	|-GameObject.GetComponent<Toggle>
	|-GameObject.GetComponent<ToggleGroup>
	|-GameObject.GetComponent<VendingPanelAdmin>
	|-GameObject.GetComponent<ViewmodelClothing>
	|-GameObject.GetComponent<VoicemailEntry>
	|-GameObject.GetComponent<Wearable>
	|-GameObject.GetComponent<WearableHolsterOffset>
	|-GameObject.GetComponent<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xBC3C0 Offset: 0xBB7C0 VA: 0x1800BC3C0
	[FreeFunctionAttribute] // RVA: 0xBC3C0 Offset: 0xBB7C0 VA: 0x1800BC3C0
	// RVA: 0x182AFC0 Offset: 0x18295C0 VA: 0x18182AFC0
	public Component GetComponent(Type type) { }

	[NativeWritableSelfAttribute] // RVA: 0xBC590 Offset: 0xBB990 VA: 0x1800BC590
	[FreeFunctionAttribute] // RVA: 0xBC590 Offset: 0xBB990 VA: 0x1800BC590
	// RVA: 0x182AEB0 Offset: 0x18294B0 VA: 0x18182AEB0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunctionAttribute] // RVA: 0xBDB60 Offset: 0xBCF60 VA: 0x1800BDB60
	[TypeInferenceRuleAttribute] // RVA: 0xBDB60 Offset: 0xBCF60 VA: 0x1800BDB60
	// RVA: 0x182AF10 Offset: 0x1829510 VA: 0x18182AF10
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3C40 Offset: 0x15A2240 VA: 0x1815A3C40
	|-GameObject.GetComponentInChildren<AnimationEvents>
	|-GameObject.GetComponentInChildren<DungeonGridLink>
	|-GameObject.GetComponentInChildren<DungeonVolume>
	|-GameObject.GetComponentInChildren<ERSurfaceScript>
	|-GameObject.GetComponentInChildren<OQQCCQCDQQ>
	|-GameObject.GetComponentInChildren<ItemButtonTools>
	|-GameObject.GetComponentInChildren<LadderMinMountHeight>
	|-GameObject.GetComponentInChildren<PaintableItem>
	|-GameObject.GetComponentInChildren<ProceduralObject>
	|-GameObject.GetComponentInChildren<HttpImage>
	|-GameObject.GetComponentInChildren<TextMeshProUGUI>
	|-GameObject.GetComponentInChildren<TooltipContainer>
	|-GameObject.GetComponentInChildren<LODGroup>
	|-GameObject.GetComponentInChildren<LineRenderer>
	|-GameObject.GetComponentInChildren<Rigidbody>
	|-GameObject.GetComponentInChildren<Button>
	|-GameObject.GetComponentInChildren<Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3C70 Offset: 0x15A2270 VA: 0x1815A3C70
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDE20 Offset: 0xBD220 VA: 0x1800BDE20
	[TypeInferenceRuleAttribute] // RVA: 0xBDE20 Offset: 0xBD220 VA: 0x1800BDE20
	// RVA: 0x182AF70 Offset: 0x1829570 VA: 0x18182AF70
	public Component GetComponentInParent(Type type) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3D50 Offset: 0x15A2350 VA: 0x1815A3D50
	|-GameObject.GetComponentInParent<BaseEntity>
	|-GameObject.GetComponentInParent<BaseViewModel>
	|-GameObject.GetComponentInParent<DropMe>
	|-GameObject.GetComponentInParent<IProvider>
	|-GameObject.GetComponentInParent<Model>
	|-GameObject.GetComponentInParent<Poolable>
	|-GameObject.GetComponentInParent<Ragdoll>
	|-GameObject.GetComponentInParent<RustControl>
	|-GameObject.GetComponentInParent<SoundSource>
	|-GameObject.GetComponentInParent<IPointerDownHandler>
	|-GameObject.GetComponentInParent<ISubmitHandler>
	|-GameObject.GetComponentInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDFB0 Offset: 0xBD3B0 VA: 0x1800BDFB0
	// RVA: 0x182B0E0 Offset: 0x18296E0 VA: 0x18182B0E0
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x182B160 Offset: 0x1829760 VA: 0x18182B160
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38FA0 Offset: 0x1A375A0 VA: 0x181A38FA0
	|-GameObject.GetComponents<ConstructionGrade>
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<Graphic>
	|-GameObject.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE2E0 Offset: 0x5CC8E0 VA: 0x1805CE2E0
	|-GameObject.GetComponents<DecalRecycle>
	|-GameObject.GetComponents<IOnParentDestroying>
	|-GameObject.GetComponents<IOnParentSpawning>
	|-GameObject.GetComponents<IOnPostNetworkUpdate>
	|-GameObject.GetComponents<IOnSendNetworkUpdate>
	|-GameObject.GetComponents<RendererBatch>
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<Component>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182B010 Offset: 0x1829610 VA: 0x18182B010
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x182B020 Offset: 0x1829620 VA: 0x18182B020
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38DA0 Offset: 0x1A373A0 VA: 0x181A38DA0
	|-GameObject.GetComponentsInChildren<BlueprintCategoryButton>
	|-GameObject.GetComponentsInChildren<CraftingQueueIcon>
	|-GameObject.GetComponentsInChildren<SingletonComponent>
	|-GameObject.GetComponentsInChildren<TerrainPathConnect>
	|-GameObject.GetComponentsInChildren<Collider>
	|-GameObject.GetComponentsInChildren<Component>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MonoBehaviour>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Rigidbody>
	|-GameObject.GetComponentsInChildren<Image>
	|-GameObject.GetComponentsInChildren<Text>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE160 Offset: 0x5CC760 VA: 0x1805CE160
	|-GameObject.GetComponentsInChildren<IEffect>
	|-GameObject.GetComponentsInChildren<IItemSetup>
	|-GameObject.GetComponentsInChildren<IItemUpdate>
	|-GameObject.GetComponentsInChildren<MaterialReplacement>
	|-GameObject.GetComponentsInChildren<MorphCache>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3C40 Offset: 0x15A2240 VA: 0x1815A3C40
	|-GameObject.GetComponentsInChildren<ConditionalGibbable>
	|-GameObject.GetComponentsInChildren<ERSurfaceScript>
	|-GameObject.GetComponentsInChildren<ERConnectionParent>
	|-GameObject.GetComponentsInChildren<ERCrossingPrefabs>
	|-GameObject.GetComponentsInChildren<ERCrossings>
	|-GameObject.GetComponentsInChildren<ERModularRoad>
	|-GameObject.GetComponentsInChildren<ERPrefabInstance>
	|-GameObject.GetComponentsInChildren<ERRoadNetworkObject>
	|-GameObject.GetComponentsInChildren<ERRoundabouts>
	|-GameObject.GetComponentsInChildren<ERSideObjectInstance>
	|-GameObject.GetComponentsInChildren<ERSideObjectSection>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<MeshFilter>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB570 Offset: 0x5C9B70 VA: 0x1805CB570
	|-GameObject.GetComponentsInChildren<DecalRecycle>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<IOnParentDestroying>
	|-GameObject.GetComponentsInChildren<IOnParentSpawning>
	|-GameObject.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-GameObject.GetComponentsInChildren<IOnSendNetworkUpdate>
	|-GameObject.GetComponentsInChildren<LODComponent>
	|-GameObject.GetComponentsInChildren<RendererBatch>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE220 Offset: 0x5CC820 VA: 0x1805CE220
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<Canvas>
	|-GameObject.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38EA0 Offset: 0x1A374A0 VA: 0x181A38EA0
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF25A0 Offset: 0xBF0BA0 VA: 0x180BF25A0
	|-GameObject.TryGetComponent<ICustomMaterialReplacer>
	|-GameObject.TryGetComponent<INotifyEntityTrigger>
	|-GameObject.TryGetComponent<INotifyTrigger>
	|-GameObject.TryGetComponent<PatternFireworkStar>
	|-GameObject.TryGetComponent<Ragdoll>
	|-GameObject.TryGetComponent<RendererInfo>
	|-GameObject.TryGetComponent<ServerAdminUGCEntryStub>
	|-GameObject.TryGetComponent<SteamUserButton>
	|-GameObject.TryGetComponent<object>
	|-GameObject.TryGetComponent<ThrownWeapon>
	|-GameObject.TryGetComponent<MeshCollider>
	|-GameObject.TryGetComponent<MeshFilter>
	|-GameObject.TryGetComponent<SkinnedMeshRenderer>
	|-GameObject.TryGetComponent<Button>
	|-GameObject.TryGetComponent<GridLayoutGroup>
	|-GameObject.TryGetComponent<Image>
	|-GameObject.TryGetComponent<Wearable>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE390 Offset: 0xBD790 VA: 0x1800BE390
	[NativeWritableSelfAttribute] // RVA: 0xBE390 Offset: 0xBD790 VA: 0x1800BE390
	// RVA: 0x182B430 Offset: 0x1829A30 VA: 0x18182B430
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x182B260 Offset: 0x1829860 VA: 0x18182B260
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x182AD10 Offset: 0x1829310 VA: 0x18182AD10
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xBE410 Offset: 0xBD810 VA: 0x1800BE410
	// RVA: 0x182AC60 Offset: 0x1829260 VA: 0x18182AC60
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x182AC60 Offset: 0x1829260 VA: 0x18182AC60
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3B40 Offset: 0x15A2140 VA: 0x1815A3B40
	|-GameObject.AddComponent<AICoverPoint>
	|-GameObject.AddComponent<AddToHeightMap>
	|-GameObject.AddComponent<AddToWaterMap>
	|-GameObject.AddComponent<AudioInterceptComponent>
	|-GameObject.AddComponent<BaseEntityChild>
	|-GameObject.AddComponent<ColliderInfo>
	|-GameObject.AddComponent<CommunityEntity.Countdown>
	|-GameObject.AddComponent<CommunityEntity.FadeOut>
	|-GameObject.AddComponent<ConversationManager.Conversation>
	|-GameObject.AddComponent<DemoShotPlayback>
	|-GameObject.AddComponent<DemoShotRecorder>
	|-GameObject.AddComponent<DeployGuide>
	|-GameObject.AddComponent<DetachMonumentChildren>
	|-GameObject.AddComponent<ERSurfaceScript>
	|-GameObject.AddComponent<ERCrossingPrefabs>
	|-GameObject.AddComponent<ERCrossings>
	|-GameObject.AddComponent<ERIConnector>
	|-GameObject.AddComponent<ERPrefabInstance>
	|-GameObject.AddComponent<ERSideObjectInstance>
	|-GameObject.AddComponent<ERSideObjectSection>
	|-GameObject.AddComponent<ERSideWalkInstanceScript>
	|-GameObject.AddComponent<ERTerrain>
	|-GameObject.AddComponent<OQQCCQCDQQ>
	|-GameObject.AddComponent<EntityDebug>
	|-GameObject.AddComponent<EnvironmentVolume>
	|-GameObject.AddComponent<ExplosionDemoReactivator>
	|-GameObject.AddComponent<ApplicationControllerMonobehaviour>
	|-GameObject.AddComponent<BurstClothManager>
	|-GameObject.AddComponent<Skeleton>
	|-GameObject.AddComponent<TickComponent>
	|-GameObject.AddComponent<Gib>
	|-GameObject.AddComponent<HudMenuInput>
	|-GameObject.AddComponent<InvokeHandler>
	|-GameObject.AddComponent<InvokeHandlerFixedTime>
	|-GameObject.AddComponent<LightLOD>
	|-GameObject.AddComponent<LoadBalancer>
	|-GameObject.AddComponent<MeshLOD>
	|-GameObject.AddComponent<MeshPaintable3D>
	|-GameObject.AddComponent<MeshPaintable>
	|-GameObject.AddComponent<MidiConvar>
	|-GameObject.AddComponent<NeedsCursor>
	|-GameObject.AddComponent<NeedsKeyboard>
	|-GameObject.AddComponent<NeedsKeyboardInputField>
	|-GameObject.AddComponent<ObjectMotionVectorFix>
	|-GameObject.AddComponent<PlayerLoot>
	|-GameObject.AddComponent<PowerLineWire>
	|-GameObject.AddComponent<PowerLineWireSpan>
	|-GameObject.AddComponent<QueryVis>
	|-GameObject.AddComponent<ReflectionProbeEx>
	|-GameObject.AddComponent<RendererInfo>
	|-GameObject.AddComponent<RiverInfo>
	|-GameObject.AddComponent<DepthOfFieldFocusPoint>
	|-GameObject.AddComponent<LightingOverride>
	|-GameObject.AddComponent<NullMonoBehaviour>
	|-GameObject.AddComponent<IconOutline>
	|-GameObject.AddComponent<PropRenderer>
	|-GameObject.AddComponent<WorkshopSkin>
	|-GameObject.AddComponent<TMP_InputField>
	|-GameObject.AddComponent<TMP_SelectionCaret>
	|-GameObject.AddComponent<TMP_SubMeshUI>
	|-GameObject.AddComponent<TextMeshProUGUI>
	|-GameObject.AddComponent<TerrainAlphaMap>
	|-GameObject.AddComponent<TerrainBiomeMap>
	|-GameObject.AddComponent<TerrainCollision>
	|-GameObject.AddComponent<TerrainColors>
	|-GameObject.AddComponent<TerrainHeightMap>
	|-GameObject.AddComponent<TerrainMeta>
	|-GameObject.AddComponent<TerrainPath>
	|-GameObject.AddComponent<TerrainPhysics>
	|-GameObject.AddComponent<TerrainPlacementMap>
	|-GameObject.AddComponent<TerrainQuality>
	|-GameObject.AddComponent<TerrainSplatMap>
	|-GameObject.AddComponent<TerrainTexturing>
	|-GameObject.AddComponent<TerrainTopologyMap>
	|-GameObject.AddComponent<TerrainWaterMap>
	|-GameObject.AddComponent<TrainTrackSpline>
	|-GameObject.AddComponent<UIEscapeCapture>
	|-GameObject.AddComponent<AudioReverbZone>
	|-GameObject.AddComponent<AudioSource>
	|-GameObject.AddComponent<BoxCollider>
	|-GameObject.AddComponent<Camera>
	|-GameObject.AddComponent<Canvas>
	|-GameObject.AddComponent<CanvasGroup>
	|-GameObject.AddComponent<CanvasRenderer>
	|-GameObject.AddComponent<BaseInput>
	|-GameObject.AddComponent<LODGroup>
	|-GameObject.AddComponent<Light>
	|-GameObject.AddComponent<MeshCollider>
	|-GameObject.AddComponent<MeshFilter>
	|-GameObject.AddComponent<MeshRenderer>
	|-GameObject.AddComponent<RectTransform>
	|-GameObject.AddComponent<ReflectionProbe>
	|-GameObject.AddComponent<Renderer>
	|-GameObject.AddComponent<PostProcessVolume>
	|-GameObject.AddComponent<Rigidbody>
	|-GameObject.AddComponent<SkinnedMeshRenderer>
	|-GameObject.AddComponent<SpringJoint>
	|-GameObject.AddComponent<StreamingController>
	|-GameObject.AddComponent<Button>
	|-GameObject.AddComponent<Dropdown.DropdownItem>
	|-GameObject.AddComponent<Image>
	|-GameObject.AddComponent<InputField>
	|-GameObject.AddComponent<LayoutElement>
	|-GameObject.AddComponent<Outline>
	|-GameObject.AddComponent<RawImage>
	|-GameObject.AddComponent<RectMask2D>
	|-GameObject.AddComponent<Scrollbar>
	|-GameObject.AddComponent<Text>
	|-GameObject.AddComponent<UpdateHandler>
	|-GameObject.AddComponent<ViewModelRenderer>
	|-GameObject.AddComponent<WaterBody>
	|-GameObject.AddComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE4F0 Offset: 0xBD8F0 VA: 0x1800BE4F0
	// RVA: 0x182B7E0 Offset: 0x1829DE0 VA: 0x18182B7E0
	public Transform get_transform() { }

	// RVA: 0x182B760 Offset: 0x1829D60 VA: 0x18182B760
	public int get_layer() { }

	// RVA: 0x182B870 Offset: 0x1829E70 VA: 0x18182B870
	public void set_layer(int value) { }

	[NativeMethodAttribute] // RVA: 0xBE700 Offset: 0xBDB00 VA: 0x1800BE700
	// RVA: 0x182B3E0 Offset: 0x18299E0 VA: 0x18182B3E0
	public void SetActive(bool value) { }

	[NativeMethodAttribute] // RVA: 0xBE780 Offset: 0xBDB80 VA: 0x1800BE780
	// RVA: 0x182B6E0 Offset: 0x1829CE0 VA: 0x18182B6E0
	public bool get_activeSelf() { }

	[NativeMethodAttribute] // RVA: 0xBE900 Offset: 0xBDD00 VA: 0x1800BE900
	// RVA: 0x182B6A0 Offset: 0x1829CA0 VA: 0x18182B6A0
	public bool get_activeInHierarchy() { }

	[NativeMethodAttribute] // RVA: 0xBEA40 Offset: 0xBDE40 VA: 0x1800BEA40
	// RVA: 0x182B720 Offset: 0x1829D20 VA: 0x18182B720
	public bool get_isStatic() { }

	[NativeMethodAttribute] // RVA: 0xBEB90 Offset: 0xBDF90 VA: 0x1800BEB90
	// RVA: 0x182B820 Offset: 0x1829E20 VA: 0x18182B820
	public void set_isStatic(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xBEC10 Offset: 0xBE010 VA: 0x1800BEC10
	// RVA: 0x182B7A0 Offset: 0x1829DA0 VA: 0x18182B7A0
	public string get_tag() { }

	[FreeFunctionAttribute] // RVA: 0xBED10 Offset: 0xBE110 VA: 0x1800BED10
	// RVA: 0x182B8B0 Offset: 0x1829EB0 VA: 0x18182B8B0
	public void set_tag(string value) { }

	[FreeFunctionAttribute] // RVA: 0xBEDC0 Offset: 0xBE1C0 VA: 0x1800BEDC0
	// RVA: 0x182ADE0 Offset: 0x18293E0 VA: 0x18182ADE0
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xBEEF0 Offset: 0xBE2F0 VA: 0x1800BEEF0
	// RVA: 0x182B370 Offset: 0x1829970 VA: 0x18182B370
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182B310 Offset: 0x1829910 VA: 0x18182B310
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182B2C0 Offset: 0x18298C0 VA: 0x18182B2C0
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xBF0E0 Offset: 0xBE4E0 VA: 0x1800BF0E0
	// RVA: 0x182AD70 Offset: 0x1829370 VA: 0x18182AD70
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x182ACB0 Offset: 0x18292B0 VA: 0x18182ACB0
	public void BroadcastMessage(string methodName, object parameter) { }

	// RVA: 0x182B610 Offset: 0x1829C10 VA: 0x18182B610
	public void .ctor(string name) { }

	// RVA: 0x182B590 Offset: 0x1829B90 VA: 0x18182B590
	public void .ctor() { }

	// RVA: 0x182B490 Offset: 0x1829A90 VA: 0x18182B490
	public void .ctor(string name, Type[] components) { }

	[FreeFunctionAttribute] // RVA: 0xC0710 Offset: 0xBFB10 VA: 0x1800C0710
	// RVA: 0x182B210 Offset: 0x1829810 VA: 0x18182B210
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunctionAttribute] // RVA: 0xC0870 Offset: 0xBFC70 VA: 0x1800C0870
	// RVA: 0x182AE70 Offset: 0x1829470 VA: 0x18182AE70
	public static GameObject Find(string name) { }

	// RVA: 0xEC13A0 Offset: 0xEBF9A0 VA: 0x180EC13A0
	public GameObject get_gameObject() { }

}

