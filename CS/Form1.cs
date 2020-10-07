using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;

namespace BarcodesExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private enum BarCodeTypes {
            Codabar, Code11, Code39, Code39Extended, Code93, Code93Extended, Code128, EAN8, EAN13,
            GS1128, GS1DataBar, DataMatrix, DataMatrixGS1, Industrial2of5, IntelligentMail,
            IntelligentMailPackage, Interleaved2of5, Matrix2of5, CodeMSI, PDF417, PostNet, QRCode, UPCA,
            UPCE0, UPCE1, UPCSupplemental2, UPCSupplemental5, UPCShippingContainer, Pharmacode
        };

        private class BarCode {
            public BarCodeTypes Type { get; set; }
            public string DisplayName { get; set; }

            public BarCode(BarCodeTypes BarCodeType, string BarCodeName) {
                Type = BarCodeType;
                DisplayName = BarCodeName;
            }
        }

        private List<BarCode> MakeBarCodesList() {
            List<BarCode> list = new List<BarCode>();

            list.Add(new BarCode(BarCodeTypes.Codabar, "Codabar"));
            list.Add(new BarCode(BarCodeTypes.Code11, "Code 11 (USD-8)"));
            list.Add(new BarCode(BarCodeTypes.Code39, "Code 39 (USD-3)"));
            list.Add(new BarCode(BarCodeTypes.Code39Extended, "Code 39 Extended"));
            list.Add(new BarCode(BarCodeTypes.Code93, "Code 93"));
            list.Add(new BarCode(BarCodeTypes.Code93Extended, "Code 93 Extended"));
            list.Add(new BarCode(BarCodeTypes.Code128, "Code 128"));
            list.Add(new BarCode(BarCodeTypes.EAN8, "EAN 8"));
            list.Add(new BarCode(BarCodeTypes.EAN13, "EAN 13"));
            list.Add(new BarCode(BarCodeTypes.GS1128, "GS1-128 - EAN-128 (UCC)"));
            list.Add(new BarCode(BarCodeTypes.GS1DataBar, "GS1 DataBar"));
            list.Add(new BarCode(BarCodeTypes.DataMatrix, "Data Matrix (ECC200)"));
            list.Add(new BarCode(BarCodeTypes.DataMatrixGS1, "Data Matrix (GS1)"));
            list.Add(new BarCode(BarCodeTypes.Industrial2of5, "Industrial 2 of 5"));
            list.Add(new BarCode(BarCodeTypes.IntelligentMail, "Intelligent Mail"));
            list.Add(new BarCode(BarCodeTypes.IntelligentMailPackage, "Intelligent Mail Package"));
            list.Add(new BarCode(BarCodeTypes.Interleaved2of5, "Interleaved 2 of 5"));
            list.Add(new BarCode(BarCodeTypes.Matrix2of5, "Matrix 2 of 5"));
            list.Add(new BarCode(BarCodeTypes.CodeMSI, "MSI/Plessey"));
            list.Add(new BarCode(BarCodeTypes.PDF417, "PDF417"));
            list.Add(new BarCode(BarCodeTypes.PostNet, "PostNet"));
            list.Add(new BarCode(BarCodeTypes.QRCode, "QR Code"));
            list.Add(new BarCode(BarCodeTypes.UPCA, "UPC-A"));
            list.Add(new BarCode(BarCodeTypes.UPCE0, "UPC-E0"));
            list.Add(new BarCode(BarCodeTypes.UPCE1, "UPC-E1"));
            list.Add(new BarCode(BarCodeTypes.UPCSupplemental2, "UPC Supplemental 2"));
            list.Add(new BarCode(BarCodeTypes.UPCShippingContainer, "UPC Shipping Container Symbol (ITF-14)"));
            list.Add(new BarCode(BarCodeTypes.Pharmacode, "Pharmacode"));

            return list;
        }

        public XRBarCode CreateCodabarBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Codabar
            barCode.Symbology = new CodabarGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 300;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((CodabarGenerator)barCode.Symbology).StartSymbol = CodabarStartStopSymbol.C;
            ((CodabarGenerator)barCode.Symbology).StopSymbol = CodabarStartStopSymbol.D;
            ((CodabarGenerator)barCode.Symbology).WideNarrowRatio = 2.5F;

            return barCode;
        }

        public XRBarCode CreateCode11BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Code 11.
            barCode.Symbology = new Code11Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            return barCode;
        }

        public XRBarCode CreateCode39BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Code 39.
            barCode.Symbology = new Code39Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Code39Generator)barCode.Symbology).CalcCheckSum = false;
            ((Code39Generator)barCode.Symbology).WideNarrowRatio = 2.5F;

            return barCode;
        }

        public XRBarCode CreateCode39ExBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Code 39 Extended.
            barCode.Symbology = new Code39ExtendedGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Code39ExtendedGenerator)barCode.Symbology).CalcCheckSum = false;
            ((Code39ExtendedGenerator)barCode.Symbology).WideNarrowRatio = 2.5F;

            return barCode;
        }

        public XRBarCode CreateCode93BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Code 93.
            barCode.Symbology = new Code93Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Code93Generator)barCode.Symbology).CalcCheckSum = false;

            return barCode;
        }

        public XRBarCode CreateCode93ExBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Code 93 Extended.
            barCode.Symbology = new Code93ExtendedGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Code93ExtendedGenerator)barCode.Symbology).CalcCheckSum = false;

            return barCode;
        }

        public XRBarCode CreateCode128BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Code 128.
            barCode.Symbology = new Code128Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Code128Generator)barCode.Symbology).CharacterSet = Code128Charset.CharsetB;

            return barCode;
        }

        public XRBarCode CreateEAN8BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to EAN 8.
            barCode.Symbology = new EAN8Generator();

            // Adjust the barcode's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            return barCode;
        }

        public XRBarCode CreateEAN13BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to EAN 13.
            barCode.Symbology = new EAN13Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 275;
            barCode.Height = 200;

            return barCode;
        }

        public XRBarCode CreateGS1128BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to EAN 128.
            barCode.Symbology = new EAN128Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((EAN128Generator)barCode.Symbology).CharacterSet = Code128Charset.CharsetB;

            return barCode;
        }

        public XRBarCode CreateDataBarGS1BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to GS1 DataBar.
            barCode.Symbology = new DataBarGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 250;
            barCode.Height = 160;

            // Adjust the properties specific to the bar code type.
            ((DataBarGenerator)barCode.Symbology).FNC1Substitute = "#";
            ((DataBarGenerator)barCode.Symbology).SegmentsInRow = 4;
            ((DataBarGenerator)barCode.Symbology).Type = DataBarType.ExpandedStacked;

            return barCode;
        }

        public XRBarCode CreateDataMatrixBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to DataMatrix.
            barCode.Symbology = new DataMatrixGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 150;

            // If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = true;
            //barcode.Module = 3;

            // Adjust the properties specific to the bar code type.
            ((DataMatrixGenerator)barCode.Symbology).CompactionMode = DataMatrixCompactionMode.Text;
            ((DataMatrixGenerator)barCode.Symbology).MatrixSize = DataMatrixSize.MatrixAuto;

            return barCode;
        }

        public XRBarCode CreateDataMatrixGS1BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Data Matrix GS1.
            barCode.Symbology = new DataMatrixGS1Generator();

            // Adjust the bar code's main properties.
            barCode.AutoModule = true;
            barCode.Text = BarCodeText;
            barCode.ShowText = true;
            barCode.Width = 200;
            barCode.Height = 200;

            // Adjust the properties specific to the bar code type.
            // (Assigned below are the default values.)
            ((DataMatrixGS1Generator)barCode.Symbology).FNC1Substitute = "#";
            ((DataMatrixGS1Generator)barCode.Symbology).HumanReadableText = true;
            ((DataMatrixGS1Generator)barCode.Symbology).MatrixSize = DataMatrixSize.MatrixAuto;

            return barCode;
        }

        public XRBarCode CreateIndustrial2of5BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Industrial 2 of 5.
            barCode.Symbology = new Industrial2of5Generator();

            // Adjust the main properties of the bar code.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Industrial2of5Generator)barCode.Symbology).CalcCheckSum = false;
            ((Industrial2of5Generator)barCode.Symbology).WideNarrowRatio = 3;

            return barCode;
        }

        public XRBarCode CreateIntelligentMailBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Intelligent Mail.
            barCode.Symbology = new IntelligentMailGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.ShowText = true;
            barCode.WidthF = 300f;
            barCode.HeightF = 50f;

            // If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = true;
            //barcode.Module = 3;

            return barCode;
        }

        public XRBarCode CreateIntelligentMailPackageBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Intelligent Mail Package.
            barCode.Symbology = new IntelligentMailPackageGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.ShowText = false;
            barCode.WidthF = 300;
            barCode.HeightF = 150f;

            // If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = true;
            //barcode.Module = 3;

            // Adjust the property specific to the bar code type.
            // (Assigned below is the default value.)
            ((IntelligentMailPackageGenerator)barCode.Symbology).FNC1Substitute = "#";

            return barCode;
        }

        public XRBarCode CreateInterleaved2of5BarCode(string BarCodeText) {
            // Create a bar code controle.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Interleaved 2 of 5.
            barCode.Symbology = new Interleaved2of5Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Interleaved2of5Generator)barCode.Symbology).CalcCheckSum = false;
            ((Interleaved2of5Generator)barCode.Symbology).WideNarrowRatio = 3;

            return barCode;
        }

        public XRBarCode CreateMatrix2of5BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to Matrix 2 of 5.
            barCode.Symbology = new Matrix2of5Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((Matrix2of5Generator)barCode.Symbology).CalcCheckSum = false;
            ((Matrix2of5Generator)barCode.Symbology).WideNarrowRatio = 3;

            return barCode;
        }

        public XRBarCode CreateCodeMSIBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to MSI.
            barCode.Symbology = new CodeMSIGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((CodeMSIGenerator)barCode.Symbology).MSICheckSum = MSICheckSum.DoubleModulo10;

            return barCode;
        }

        public XRBarCode CreatePDF417BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to PDF417.
            barCode.Symbology = new PDF417Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 150;

            // If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = true;
            //barcode.Module = 3;

            // Adjust the properties specific to the bar code type.
            ((PDF417Generator)barCode.Symbology).Columns = 1;
            ((PDF417Generator)barCode.Symbology).CompactionMode = PDF417CompactionMode.Text;
            ((PDF417Generator)barCode.Symbology).ErrorCorrectionLevel = ErrorCorrectionLevel.Level2;
            ((PDF417Generator)barCode.Symbology).Rows = 9;
            ((PDF417Generator)barCode.Symbology).TruncateSymbol = false;
            ((PDF417Generator)barCode.Symbology).YToXRatio = 3;

            return barCode;
        }

        public XRBarCode CreatePostNetBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to PostNet.
            barCode.Symbology = new PostNetGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            return barCode;
        }

        public XRBarCode CreateQRCodeBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to QRCode.
            barCode.Symbology = new QRCodeGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 150;

            // If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = true;
            // barcode.Module = 3;

            // Adjust the properties specific to the bar code type.
            ((QRCodeGenerator)barCode.Symbology).CompactionMode = QRCodeCompactionMode.AlphaNumeric;
            ((QRCodeGenerator)barCode.Symbology).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H;
            ((QRCodeGenerator)barCode.Symbology).Version = QRCodeVersion.AutoVersion;

            return barCode;
        }

        public XRBarCode CreateUPCABarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to UPC-A.
            barCode.Symbology = new UPCAGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 275;
            barCode.Height = 200;

            return barCode;
        }

        public XRBarCode CreateUPCE0BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to UPC-E0.
            barCode.Symbology = new UPCE0Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            return barCode;
        }

        public XRBarCode CreateUPCE1BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to UPC-E1.
            barCode.Symbology = new UPCE1Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 400;
            barCode.Height = 100;

            return barCode;
        }

        public XRBarCode CreateUPCSupplemental2BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to UPC Supplemental 2.
            barCode.Symbology = new UPCSupplemental2Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 100;
            barCode.Height = 55;

            return barCode;
        }

        public XRBarCode CreateUPCSupplemental5BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to UPC Supplemental 5.
            barCode.Symbology = new UPCSupplemental5Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 150;
            barCode.Height = 55;

            return barCode;
        }

        public XRBarCode CreateITF14BarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the barcode's type to ITF-14.  
            barCode.Symbology = new ITF14Generator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 350;
            barCode.Height = 100;

            // Adjust the properties specific to the bar code type.
            ((ITF14Generator)barCode.Symbology).CalcCheckSum = false;
            ((ITF14Generator)barCode.Symbology).WideNarrowRatio = 2.5f;

            return barCode;
        }

        public XRBarCode CreatePharmacodeBarCode(string BarCodeText) {
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the type to Pharmacode
            barCode.Symbology = new PharmacodeGenerator() {
                // Specify the Pharmacode type
                PharmacodeType = PharmacodeType.OneTrack
            };

            // Adjust the appearance.
            barCode.Text = BarCodeText;
            barCode.Height = 100;
            barCode.Width = 220;

            return barCode;
        }


        private XRBarCode CreateBarCode(BarCodeTypes Type) {
            XRBarCode barCode = null;

            switch (Type) {
                case BarCodeTypes.Codabar:
                    barCode = CreateCodabarBarCode("0123-456789");
                    break;
                case BarCodeTypes.Code11:
                    barCode = CreateCode11BarCode("0123-456789");
                    break;
                case BarCodeTypes.Code39:
                    barCode = CreateCode39BarCode("01234-ABCD");
                    break;
                case BarCodeTypes.Code39Extended:
                    barCode = CreateCode39ExBarCode("012-Abc");
                    break;
                case BarCodeTypes.Code93:
                    barCode = CreateCode93BarCode("01234-ABCD");
                    break;
                case BarCodeTypes.Code93Extended:
                    barCode = CreateCode93ExBarCode("012-Abc");
                    break;
                case BarCodeTypes.Code128:
                    barCode = CreateCode128BarCode("01234-ABcd");
                    break;
                case BarCodeTypes.EAN8:
                    barCode = CreateEAN8BarCode("01234567");
                    break;
                case BarCodeTypes.EAN13:
                    barCode = CreateEAN13BarCode("0123456789");
                    break;
                case BarCodeTypes.GS1128:
                    barCode = CreateGS1128BarCode("01234-Abcd");
                    break;
                case BarCodeTypes.GS1DataBar:
                    barCode = CreateDataBarGS1BarCode("01906141410000153202000150");
                    break;
                case BarCodeTypes.DataMatrix:
                    barCode = CreateDataMatrixBarCode("01234-ABCD");
                    break;
                case BarCodeTypes.DataMatrixGS1:
                    barCode = CreateDataMatrixGS1BarCode("01234-ABCD");
                    break;
                case BarCodeTypes.Industrial2of5:
                    barCode = CreateIndustrial2of5BarCode("0123456789");
                    break;
                case BarCodeTypes.IntelligentMail:
                    barCode = CreateIntelligentMailBarCode("4408200000012345678991203");
                    break;
                case BarCodeTypes.IntelligentMailPackage:
                    barCode = CreateIntelligentMailPackageBarCode("9212391234567812345671");
                    break;
                case BarCodeTypes.Interleaved2of5:
                    barCode = CreateInterleaved2of5BarCode("0123456789");
                    break;
                case BarCodeTypes.Matrix2of5:
                    barCode = CreateMatrix2of5BarCode("0123456789");
                    break;
                case BarCodeTypes.CodeMSI:
                    barCode = CreateCodeMSIBarCode("0123456789");
                    break;
                case BarCodeTypes.PDF417:
                    barCode = CreatePDF417BarCode("01234-ABCD");
                    break;
                case BarCodeTypes.PostNet:
                    barCode = CreatePostNetBarCode("0123456789");
                    break;
                case BarCodeTypes.QRCode:
                    barCode = CreateQRCodeBarCode("01234-ABCD");
                    break;
                case BarCodeTypes.UPCA:
                    barCode = CreateUPCABarCode("00123456789");
                    break;
                case BarCodeTypes.UPCE0:
                    barCode = CreateUPCE0BarCode("123");
                    break;
                case BarCodeTypes.UPCE1:
                    barCode = CreateUPCE1BarCode("123");
                    break;
                case BarCodeTypes.UPCSupplemental2:
                    barCode = CreateUPCSupplemental2BarCode("01");
                    break;
                case BarCodeTypes.UPCSupplemental5:
                    barCode = CreateUPCSupplemental5BarCode("01234");
                    break;
                case BarCodeTypes.UPCShippingContainer:
                    barCode = CreateITF14BarCode("1234567890123");
                    break;
                case BarCodeTypes.Pharmacode:
                    barCode = CreatePharmacodeBarCode("101070");
                    break;
            }

            return barCode;
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report and handle its BeforPrint event.
            XtraReport report = new XtraReport();
            report.BeforePrint += report_BeforePrint;

            // Show the report's preview.
            report.ShowPreview();
        }

        private void report_BeforePrint(object sender, PrintEventArgs e) {
            // Create a bar code control.
            XRBarCode barCode = CreateBarCode((BarCodeTypes)comboBox1.SelectedValue);

            // Create a Detail band and add the bar code to it.
            ((XtraReport)sender).Bands.Add(new DetailBand());
            ((XtraReport)sender).Bands[BandKind.Detail].Controls.Add(barCode);
        }

        private void Form1_Load(object sender, EventArgs e) {
            List<BarCode> data = MakeBarCodesList();
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Type";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
