Polygons Custom Report Item Sample

This is a sample of the Microsoft SQL Server 2008 Reporting Services custom report item feature.


To build:
	If you have not created the root sample key, create it:
		Open a Visual Studio Command Prompt
		Use the CD command to the root samples folder, typically C:\Program Files\Microsoft SQL Server\100\Samples
		Run the command: sn -k SampleKey.snk		
	Load PolygonsCRI.sln into Visual Studio
	Build the solution (Ctrl+Shift+B)

To deploy:
	Edit rsreportserver.config to register the PolygonsCRI
		Insert the following lines before </Extensions>:
		<ReportItems>
			<ReportItem Name="Polygons" Type="Microsoft.Samples.ReportingServices.PolygonsCRI,PolygonsCRI"/>
		</ReportItems>
	Run ConfigurePoly.bat
		Copies new Reporting Services configuration files into your Reporting Services folders
	Run DeployPoly.bat
		Copies the sample Polygon control assemblies into your Reporting Services folders
		Opens the sample report in Visual Studio
	In Visual Studio, add PolygonsDesigner to the toolbox
		Right-click in the Toolbox
		Select "Choose Items..."
		On the .Net Components tab, select "Browse..."
		Navigate to "" and select PolygonsDesigner.dll

To run:
	In Visual Studio, click on the Preview tab in the sample report, or
	Deploy the sample report to the server and run the sample report
		(Be sure you've configured and deployed as above on the target server)

To edit in Visual Studio:
	Set properties of the polygons control in the property browser, or
	Edit properties via the context menu, or
	Drag fields onto the drop areas in the control from the fields list
