
#pragma warning disable 162

namespace POC_NetSuiteIntegration_Restlet.Orchestrations
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.__messagetype_System_Xml_XmlDocument), 
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.__messagetype_Microsoft_XLANGs_BaseTypes_Any)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SndJsonReqResPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SndJsonReqResPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SndJsonReqResPortType(SndJsonReqResPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SndJsonReqResPortType p = new SndJsonReqResPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SndJsonReqResPortType),
            typeof(__messagetype_System_Xml_XmlDocument),
            typeof(__messagetype_Microsoft_XLANGs_BaseTypes_Any),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.__messagetype_Microsoft_XLANGs_BaseTypes_Any)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SndJsonResponseMsgPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SndJsonResponseMsgPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SndJsonResponseMsgPortType(SndJsonResponseMsgPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SndJsonResponseMsgPortType p = new SndJsonResponseMsgPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SndJsonResponseMsgPortType),
            typeof(__messagetype_Microsoft_XLANGs_BaseTypes_Any),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RcvXmlMsgPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RcvXmlMsgPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RcvXmlMsgPortType(RcvXmlMsgPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RcvXmlMsgPortType p = new RcvXmlMsgPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(RcvXmlMsgPortType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 244 "C:\FSR\DEV_INT\POC\POC_NetSuiteIntegration_Restlet\POC_NetSuiteIntegration_Restlet.Orchestrations\JsonProcess.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvXmlMsgPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.RcvXmlMsgPortType),
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.SndJsonReqResPortType),
            typeof(POC_NetSuiteIntegration_Restlet.Orchestrations.SndJsonResponseMsgPortType)
        },
        new System.String[] {
            "RcvXmlMsgPort",
            "SndJsonReqResPort",
            "SndJsonResponseMsgPort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class JsonProcess : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(JsonProcess));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static JsonProcess()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __JsonProcess_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public JsonProcess(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "JsonProcess", tracker)
        {
            ConstructorHelper();
        }

        public JsonProcess(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "JsonProcess")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>1462b15e-77b4-4376-aeb1-df6d8e56d4be</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>7d057587-8a46-4851-94aa-7ca3447d39b1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_XmlMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>885a82e3-55da-4f95-91ef-d9e862765339</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0dd42942-4123-4bf7-9e4b-06a53f7b091a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c1c33338-574a-4b69-8ce0-895bdfadb5f4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0293663e-37ec-4cc4-800f-2010bbf8ea75</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_JsonRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>6a222890-0b98-4b62-957e-40aca95dd81c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_JsonResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7cb62231-d337-4910-80da-ab2555d5d099</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_JsonResponseOut</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'JsonProcess'</ActionName><IsAtomic>0</IsAtomic><Line>244</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>258</Line><Position>22</Position><ShapeID>'7d057587-8a46-4851-94aa-7ca3447d39b1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>260</Line><Position>13</Position><ShapeID>'885a82e3-55da-4f95-91ef-d9e862765339'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>266</Line><Position>13</Position><ShapeID>'0293663e-37ec-4cc4-800f-2010bbf8ea75'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>268</Line><Position>13</Position><ShapeID>'6a222890-0b98-4b62-957e-40aca95dd81c'</ShapeID>
<Messages>
	<MsgInfo><name>msgJsonResponseOut</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>270</Line><Position>13</Position><ShapeID>'7cb62231-d337-4910-80da-ab2555d5d099'</ShapeID>
<Messages>
	<MsgInfo><name>msgJsonResponseOut</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='70f2630d-d4a5-44d1-917f-8c708d07ad68' LowerBound='1.1' HigherBound='56.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='POC_NetSuiteIntegration_Restlet.Orchestrations' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='3ab588dc-6316-480c-8ec0-5751314b2953' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SndJsonReqResPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='72f3cc96-ae8d-4daf-9da7-4a0707dd41ee' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='83e0b49a-ab1f-4f58-a442-f8ba5e00a6e9' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.37' HigherBound='8.67'>
                    <om:Property Name='Ref' Value='Microsoft.XLANGs.BaseTypes.Any' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='4fd3962f-f8b7-426f-b735-4ac6688d1cb2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='841176c6-2694-4021-8e7a-b5c6d99b4cde' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SndJsonResponseMsgPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f50183e7-03c0-479e-97c5-b7cbbb66cd35' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='dae4a737-f6f3-4725-84ab-af50ceae8a30' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.43'>
                    <om:Property Name='Ref' Value='Microsoft.XLANGs.BaseTypes.Any' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0bd08518-c588-45cb-a94e-0835a283bfae' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RcvXmlMsgPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f43232b3-40e5-4acc-b7de-6107fd795b99' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='360b8b51-517f-4031-91f7-5b9e09d4bab2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='96a92b3b-02e6-4ea0-8aeb-ff4583ed6a4a' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='55.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='JsonProcess' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='8d066644-9f23-4721-ac5a-0ab91323ed8b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgXmlIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aed8a7ed-6d67-479e-96cd-6c2fd52c17ec' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='Microsoft.XLANGs.BaseTypes.Any' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgJsonResponseOut' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='a0b4250e-1b8c-400b-9866-215610a8f203' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgJsonIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='1462b15e-77b4-4376-aeb1-df6d8e56d4be' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='7d057587-8a46-4851-94aa-7ca3447d39b1' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvXmlMsgPort' />
                    <om:Property Name='MessageName' Value='msgXmlIn' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_XmlMessage' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='885a82e3-55da-4f95-91ef-d9e862765339' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='47.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageRef' OID='0dd42942-4123-4bf7-9e4b-06a53f7b091a' ParentLink='Construct_MessageRef' LowerBound='42.23' HigherBound='42.32'>
                        <om:Property Name='Ref' Value='msgJsonIn' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='c1c33338-574a-4b69-8ce0-895bdfadb5f4' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                        <om:Property Name='Expression' Value='msgJsonIn=msgXmlIn;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='0293663e-37ec-4cc4-800f-2010bbf8ea75' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='PortName' Value='SndJsonReqResPort' />
                    <om:Property Name='MessageName' Value='msgJsonIn' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_JsonRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='6a222890-0b98-4b62-957e-40aca95dd81c' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='51.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SndJsonReqResPort' />
                    <om:Property Name='MessageName' Value='msgJsonResponseOut' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_JsonResponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='7cb62231-d337-4910-80da-ab2555d5d099' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='53.1'>
                    <om:Property Name='PortName' Value='SndJsonResponseMsgPort' />
                    <om:Property Name='MessageName' Value='msgJsonResponseOut' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_JsonResponseOut' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1d19b04e-4571-4fd7-8fd1-8ce2bd63f944' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC_NetSuiteIntegration_Restlet.Orchestrations.SndJsonReqResPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SndJsonReqResPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='a16ef71c-d81d-4560-ad7f-b715d53782f9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a363e69f-7790-4863-aa61-30fe28dc6a17' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC_NetSuiteIntegration_Restlet.Orchestrations.RcvXmlMsgPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvXmlMsgPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='PhysicalBindingAttribute' OID='5622b928-dd99-4813-a8c8-7be4f7c9da47' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='FILE' />
                    <om:Property Name='URI' Value='C:\Nikhil\Project\FSR\DEV_INT\POC\POC_NetSuiteIntegration_Restlet\Samples\IN\*.xml' />
                    <om:Property Name='IsDynamic' Value='False' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f336e0c2-854b-4d42-a0cb-c85502cd376e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='POC_NetSuiteIntegration_Restlet.Orchestrations.SndJsonResponseMsgPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SndJsonResponseMsgPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='PhysicalBindingAttribute' OID='4321a5ec-3979-48f1-a57b-355185139f98' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruTransmit' />
                    <om:Property Name='TransportType' Value='FILE' />
                    <om:Property Name='URI' Value='C:\Nikhil\Project\FSP\DEV_INT\POC\SuiteTalkSample1\Sample\TestRestlet\Out\%MessageID%.xml' />
                    <om:Property Name='IsDynamic' Value='False' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __JsonProcess_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __JsonProcess_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "JsonProcess")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                JsonProcess __svc__ = (JsonProcess)_service;
                __JsonProcess_root_0 __ctx0__ = (__JsonProcess_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SndJsonReqResPort != null)
                {
                    __svc__.SndJsonReqResPort.Close(this, null);
                    __svc__.SndJsonReqResPort = null;
                }
                if (__svc__.RcvXmlMsgPort != null)
                {
                    __svc__.RcvXmlMsgPort.Close(this, null);
                    __svc__.RcvXmlMsgPort = null;
                }
                if (__svc__.SndJsonResponseMsgPort != null)
                {
                    __svc__.SndJsonResponseMsgPort.Close(this, null);
                    __svc__.SndJsonResponseMsgPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __JsonProcess_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __JsonProcess_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "JsonProcess")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                JsonProcess __svc__ = (JsonProcess)_service;
                __JsonProcess_root_0 __ctx0__ = (__JsonProcess_root_0)(__svc__._stateMgrs[0]);
                __JsonProcess_1 __ctx1__ = (__JsonProcess_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgXmlIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgXmlIn);
                    __ctx1__.__msgXmlIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgJsonResponseOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgJsonResponseOut);
                    __ctx1__.__msgJsonResponseOut = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgJsonIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgJsonIn);
                    __ctx1__.__msgJsonIn = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgXmlIn")]
            public __messagetype_System_Xml_XmlDocument __msgXmlIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgJsonResponseOut")]
            public __messagetype_Microsoft_XLANGs_BaseTypes_Any __msgJsonResponseOut;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgJsonIn")]
            public __messagetype_System_Xml_XmlDocument __msgJsonIn;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute("FILE", "C:\\Nikhil\\Project\\FSR\\DEV_INT\\POC\\POC_NetSuiteIntegration_Restlet\\Samples\\IN\\*.xml", typeof(Microsoft.BizTalk.DefaultPipelines.PassThruReceive))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvXmlMsgPort")]
        internal RcvXmlMsgPortType RcvXmlMsgPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SndJsonReqResPort")]
        internal SndJsonReqResPortType SndJsonReqResPort;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute("FILE", "C:\\Nikhil\\Project\\FSP\\DEV_INT\\POC\\SuiteTalkSample1\\Sample\\TestRestlet\\Out\\%MessageID%.xml", typeof(Microsoft.BizTalk.DefaultPipelines.PassThruTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SndJsonResponseMsgPort")]
        internal SndJsonResponseMsgPortType SndJsonResponseMsgPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RcvXmlMsgPortType.Operation_1},
                                               typeof(JsonProcess).GetField("RcvXmlMsgPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(JsonProcess), "RcvXmlMsgPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SndJsonReqResPortType.Operation_1},
                                               typeof(JsonProcess).GetField("SndJsonReqResPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(JsonProcess), "SndJsonReqResPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SndJsonResponseMsgPortType.Operation_1},
                                               typeof(JsonProcess).GetField("SndJsonResponseMsgPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(JsonProcess), "SndJsonResponseMsgPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "7d057587-8a46-4851-94aa-7ca3447d39b1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "7d057587-8a46-4851-94aa-7ca3447d39b1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "885a82e3-55da-4f95-91ef-d9e862765339", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "885a82e3-55da-4f95-91ef-d9e862765339", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "0293663e-37ec-4cc4-800f-2010bbf8ea75", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "0293663e-37ec-4cc4-800f-2010bbf8ea75", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "6a222890-0b98-4b62-957e-40aca95dd81c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "6a222890-0b98-4b62-957e-40aca95dd81c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "7cb62231-d337-4910-80da-ab2555d5d099", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "7cb62231-d337-4910-80da-ab2555d5d099", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __JsonProcess_root_0 __ctx0__ = (__JsonProcess_root_0)_stateMgrs[0];
            __JsonProcess_1 __ctx1__ = (__JsonProcess_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                SndJsonReqResPort = new SndJsonReqResPortType(1, this);
                RcvXmlMsgPort = new RcvXmlMsgPortType(0, this);
                SndJsonResponseMsgPort = new SndJsonResponseMsgPortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvXmlMsgPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __JsonProcess_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __JsonProcess_root_0 __ctx0__ = (__JsonProcess_root_0)_stateMgrs[0];
            __JsonProcess_1 __ctx1__ = (__JsonProcess_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!RcvXmlMsgPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgXmlIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgXmlIn);
                __ctx1__.__msgXmlIn = new __messagetype_System_Xml_XmlDocument("msgXmlIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgXmlIn);
                RcvXmlMsgPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgXmlIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvXmlMsgPort != null)
                {
                    RcvXmlMsgPort.Close(__ctx1__, __seg__);
                    RcvXmlMsgPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgXmlIn);
                    __edata.PortName = @"RcvXmlMsgPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_System_Xml_XmlDocument __msgJsonIn = new __messagetype_System_Xml_XmlDocument("msgJsonIn", __ctx1__);

                    __msgJsonIn.CopyFrom(__ctx1__.__msgXmlIn);
                    if (__ctx1__ != null && __ctx1__.__msgXmlIn != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__msgXmlIn);
                        __ctx1__.__msgXmlIn = null;
                    }

                    if (__ctx1__.__msgJsonIn != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgJsonIn);
                    __ctx1__.__msgJsonIn = __msgJsonIn;
                    __ctx1__.RefMessage(__ctx1__.__msgJsonIn);
                }
                __ctx1__.__msgJsonIn.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgJsonIn);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SndJsonReqResPort.SendMessage(0, __ctx1__.__msgJsonIn, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgJsonIn);
                    __edata.PortName = @"SndJsonReqResPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgJsonIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgJsonIn);
                    __ctx1__.__msgJsonIn = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!SndJsonReqResPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgJsonResponseOut != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgJsonResponseOut);
                __ctx1__.__msgJsonResponseOut = new __messagetype_Microsoft_XLANGs_BaseTypes_Any("msgJsonResponseOut", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgJsonResponseOut);
                SndJsonReqResPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgJsonResponseOut, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SndJsonReqResPort != null)
                {
                    SndJsonReqResPort.Close(__ctx1__, __seg__);
                    SndJsonReqResPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgJsonResponseOut);
                    __edata.PortName = @"SndJsonReqResPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SndJsonResponseMsgPort.SendMessage(0, __ctx1__.__msgJsonResponseOut, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SndJsonResponseMsgPort != null)
                {
                    SndJsonResponseMsgPort.Close(__ctx1__, __seg__);
                    SndJsonResponseMsgPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgJsonResponseOut);
                    __edata.PortName = @"SndJsonResponseMsgPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgJsonResponseOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgJsonResponseOut);
                    __ctx1__.__msgJsonResponseOut = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{642FFBD1-B8AE-4F2B-85B8-6FA0704D9045}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Microsoft.XLANGs.BaseTypes.Any",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Microsoft_XLANGs_BaseTypes_Any : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Microsoft_XLANGs_BaseTypes_Any(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
