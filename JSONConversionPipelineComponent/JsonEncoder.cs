using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Collections;

namespace JSONConversionPipelineComponent
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [Guid("0A0F6146-05DC-4A5E-B362-13CD18C64CC3")]
    public class JsonEncoder : IBaseComponent, IComponentUI, IPersistPropertyBag, IComponent
    {
        #region IBaseComponent Members

        public string Description
        {
            get
            {
                return "JSON Encoder";
            }
        }

        public string Name
        {
            get
            {
                return "JSONEncoder";
            }
        }

        public string Version
        {
            get
            {
                return "1.0";
            }
        }

        #endregion

        #region IComponent

        /// <summary>
        /// Implements IComponent.Execute method.
        /// </summary>
        /// <param name="pc">Pipeline context</param>
        /// <param name="inmsg">Input message.</param>
        /// <returns>Processed input message with standard error format and sends to Status location.</returns>
        /// <remarks>
        /// IComponent.Execute method is used to initiate
        /// the processing of the message in pipeline component.
        /// </remarks>
        public IBaseMessage Execute(IPipelineContext pc, IBaseMessage inmsg)
        {
            //reads the context properties required from message context

            IBaseMessagePart bodyPart = inmsg.BodyPart;
            Stream originalStream = bodyPart.GetOriginalDataStream();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(originalStream);

            string jsonString = string.Empty;

            if (bodyPart != null)
            {
                jsonString = JsonConvert.SerializeXmlNode(xmlDoc, Newtonsoft.Json.Formatting.Indented, true);

            }
            byte[] outBytes = System.Text.Encoding.ASCII.GetBytes(jsonString);

            MemoryStream memStream = new MemoryStream();

            memStream.Write(outBytes, 0, outBytes.Length);

            memStream.Position = 0;
            bodyPart.Data = memStream;
            pc.ResourceTracker.AddResource(memStream);

            return inmsg;
        }
        #endregion

        #region IComponentUI Members


        public IntPtr Icon
        {
            get
            {

                return System.IntPtr.Zero;
            }

        }

        /// <summary>
        /// The Validate method is called by the BizTalk Editor during the build 
        /// of a BizTalk project.
        /// </summary>
        /// <param name="obj">Project system.</param>
        /// <returns>
        /// A list of error and/or warning messages encounter during validation
        /// of this component.
        /// </returns>
        public IEnumerator Validate(object obj)
        {
            return null;
        }

        #endregion

        #region IPersistPropertyBag

        /// <summary>
        /// Gets class ID of component for usage from unmanaged code.
        /// </summary>
        /// <param name="classid">Class ID of the component.</param>
        public void GetClassID(out Guid classid)
        {
            classid = new System.Guid("0A0F6146-05DC-4A5E-B362-13CD18C64CC3");
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        public void InitNew()
        {
        }

        /// <summary>
        /// Loads configuration property for component.
        /// </summary>
        /// <param name="pb">Configuration property bag.</param>
        /// <param name="errlog">Error status (not used in this code).</param>
        public void Load(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, Int32 errlog)
        {
            //string valRecordXPath = (string)ReadPropertyBag(pb, "RecordXPath");
            //if (valRecordXPath != null) recordXpath = valRecordXPath;

            //string valBatchSize = (string)ReadPropertyBag(pb, "BatchSize");
            //if (valBatchSize != null) batchSize = valBatchSize;

            //string valOutputPath = (string)ReadPropertyBag(pb, "OutputPath");
            //if (valOutputPath != null) outputPath = valOutputPath;

        }

        /// <summary>
        /// Saves the current component configuration into the property bag.
        /// </summary>
        /// <param name="pb">Configuration property bag.</param>
        /// <param name="fClearDirty">Not used.</param>
        /// <param name="fSaveAllProperties">Not used.</param>
        public void Save(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, Boolean fClearDirty, Boolean fSaveAllProperties)
        {
            //object valRecordXPath = (object)recordXpath;
            //WritePropertyBag(pb, "RecordXPath", valRecordXPath);

            //object valBatchSize = (object)batchSize;
            //WritePropertyBag(pb, "BatchSize", valBatchSize);

            //object valOutputPath = (object)outputPath;
            //WritePropertyBag(pb, "OutputPath", valOutputPath);

        }

        /// <summary>
        /// Reads property value from property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <returns>Value of the property.</returns>
        private static object ReadPropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName)
        {
            object val = null;
            try
            {
                pb.Read(propName, out val, 0);
            }

            catch (ArgumentException)
            {
                return val;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return val;
        }

        /// <summary>
        /// Writes property values into a property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <param name="val">Value of property.</param>
        private static void WritePropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName, object val)
        {
            try
            {
                pb.Write(propName, ref val);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }




        #endregion
    }

}
