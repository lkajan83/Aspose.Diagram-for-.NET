//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Diagram. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Diagram;

namespace CSharp.Shapes
{
    public class SetFillData
    {
        public static void Run()
        {
            //ExStart:SetFillData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes();

            //Call the diagram constructor to load diagram from a VSD file
            Diagram vdxDiagram = new Diagram(dataDir + "SetFillData.vsd");

            //Find a particular shape and update its XForm
            foreach (Aspose.Diagram.Shape shape in vdxDiagram.Pages[0].Shapes)
            {
                if (shape.NameU.ToLower() == "rectangle" && shape.ID == 1)
                {
                    shape.Fill.FillBkgnd.Value = vdxDiagram.Pages[1].Shapes[0].Fill.FillBkgnd.Value;
                    shape.Fill.FillForegnd.Value = "#ebf8df";
                }
            }
            vdxDiagram.Save(dataDir + "output.vdx", SaveFileFormat.VDX);
            //ExEnd:SetFillData
        }
    }
}