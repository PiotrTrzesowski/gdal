/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.24
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System.Runtime.InteropServices;
using System.Reflection;
[assembly: AssemblyKeyFile( "gdal.snk" )]

namespace GDALInterop
{
	using GDAL;
	[InterfaceTypeAttribute( ComInterfaceType.InterfaceIsIDispatch )]
	public interface IComInterop
	{
		Dataset Open(string name, int eAccess);
		void AllRegister();

	}
}


namespace GDALInterop
{
	using GDAL;
	using System;
	public class GDAL2: IComInterop
	{
		public Dataset Open(string name, int eAccess) 
		{
			IntPtr cPtr = gdalPINVOKE.Open(name, eAccess);
			return (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true);
		}
		public void AllRegister() 
		{
			gdalPINVOKE.AllRegister();
		}
	}
}
namespace GDAL {

using System;

public class gdal {
  public static void Debug(string msg_class, string message) {
    gdalPINVOKE.Debug(msg_class, message);
  }

  public static void Error(int msg_class, int err_code, string msg) {
    gdalPINVOKE.Error(msg_class, err_code, msg);
  }

  public static int PushErrorHandler(string pszCallbackName) {
    return gdalPINVOKE.PushErrorHandler__SWIG_0(pszCallbackName);
  }

  public static void PushErrorHandler(SWIGTYPE_p_CPLErrorHandler arg0) {
    gdalPINVOKE.PushErrorHandler__SWIG_1(SWIGTYPE_p_CPLErrorHandler.getCPtr(arg0));
  }

  public static void PopErrorHandler() {
    gdalPINVOKE.PopErrorHandler();
  }

  public static void ErrorReset() {
    gdalPINVOKE.ErrorReset();
  }

  public static int GetLastErrorNo() {
    return gdalPINVOKE.GetLastErrorNo();
  }

  public static int GetLastErrorType() {
    return gdalPINVOKE.GetLastErrorType();
  }

  public static string GetLastErrorMsg() {
    return gdalPINVOKE.GetLastErrorMsg();
  }

  public static void PushFinderLocation(string arg0) {
    gdalPINVOKE.PushFinderLocation(arg0);
  }

  public static void PopFinderLocation() {
    gdalPINVOKE.PopFinderLocation();
  }

  public static void FinderClean() {
    gdalPINVOKE.FinderClean();
  }

  public static string FindFile(string arg0, string arg1) {
    return gdalPINVOKE.FindFile(arg0, arg1);
  }

  public static void SetConfigOption(string arg0, string arg1) {
    gdalPINVOKE.SetConfigOption(arg0, arg1);
  }

  public static string GetConfigOption(string arg0, string arg1) {
    return gdalPINVOKE.GetConfigOption(arg0, arg1);
  }

  public static double GDAL_GCP_GCPX_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_GCPX_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_GCPX_set(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_GCPX_set(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_GCPY_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_GCPY_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_GCPY_set(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_GCPY_set(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_GCPZ_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_GCPZ_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_GCPZ_set(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_GCPZ_set(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_GCPPixel_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_GCPPixel_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_GCPPixel_set(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_GCPPixel_set(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_GCPLine_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_GCPLine_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_GCPLine_set(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_GCPLine_set(GCP.getCPtr(h), val);
  }

  public static string GDAL_GCP_Info_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_Info_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_Info_set(GCP h, string val) {
    gdalPINVOKE.GDAL_GCP_Info_set(GCP.getCPtr(h), val);
  }

  public static string GDAL_GCP_Id_get(GCP h) {
    return gdalPINVOKE.GDAL_GCP_Id_get(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_Id_set(GCP h, string val) {
    gdalPINVOKE.GDAL_GCP_Id_set(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_get_GCPX(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_GCPX(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_GCPX(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_set_GCPX(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_get_GCPY(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_GCPY(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_GCPY(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_set_GCPY(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_get_GCPZ(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_GCPZ(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_GCPZ(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_set_GCPZ(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_get_GCPPixel(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_GCPPixel(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_GCPPixel(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_set_GCPPixel(GCP.getCPtr(h), val);
  }

  public static double GDAL_GCP_get_GCPLine(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_GCPLine(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_GCPLine(GCP h, double val) {
    gdalPINVOKE.GDAL_GCP_set_GCPLine(GCP.getCPtr(h), val);
  }

  public static string GDAL_GCP_get_Info(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_Info(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_Info(GCP h, string val) {
    gdalPINVOKE.GDAL_GCP_set_Info(GCP.getCPtr(h), val);
  }

  public static string GDAL_GCP_get_Id(GCP h) {
    return gdalPINVOKE.GDAL_GCP_get_Id(GCP.getCPtr(h));
  }

  public static void GDAL_GCP_set_Id(GCP h, string val) {
    gdalPINVOKE.GDAL_GCP_set_Id(GCP.getCPtr(h), val);
  }

  public static SWIGTYPE_p_FALSE_IS_ERR GCPsToGeoTransform(int nGCPs, GCP pGCPs, SWIGTYPE_p_double_6 argout, int bApproxOK) {
    return new SWIGTYPE_p_FALSE_IS_ERR(gdalPINVOKE.GCPsToGeoTransform(nGCPs, GCP.getCPtr(pGCPs), SWIGTYPE_p_double_6.getCPtr(argout), bApproxOK), true);
  }

  public static void AllRegister() {
    gdalPINVOKE.AllRegister();
  }

  public static int GetCacheMax() {
    return gdalPINVOKE.GetCacheMax();
  }

  public static void SetCacheMax(int nBytes) {
    gdalPINVOKE.SetCacheMax(nBytes);
  }

  public static int GetCacheUsed() {
    return gdalPINVOKE.GetCacheUsed();
  }

  public static int GetDataTypeSize(int arg0) {
    return gdalPINVOKE.GetDataTypeSize(arg0);
  }

  public static int DataTypeIsComplex(int arg0) {
    return gdalPINVOKE.DataTypeIsComplex(arg0);
  }

  public static string GetDataTypeName(int arg0) {
    return gdalPINVOKE.GetDataTypeName(arg0);
  }

  public static int GetDataTypeByName(string arg0) {
    return gdalPINVOKE.GetDataTypeByName(arg0);
  }

  public static string GetColorInterpretationName(int arg0) {
    return gdalPINVOKE.GetColorInterpretationName(arg0);
  }

  public static string GetPaletteInterpretationName(int arg0) {
    return gdalPINVOKE.GetPaletteInterpretationName(arg0);
  }

  public static string DecToDMS(double arg0, string arg1, int arg2) {
    return gdalPINVOKE.DecToDMS(arg0, arg1, arg2);
  }

  public static double PackedDMSToDec(double arg0) {
    return gdalPINVOKE.PackedDMSToDec(arg0);
  }

  public static double DecToPackedDMS(double arg0) {
    return gdalPINVOKE.DecToPackedDMS(arg0);
  }

  public static Driver GetDriverByName(string name) {
    IntPtr cPtr = gdalPINVOKE.GetDriverByName(name);
    return (cPtr == IntPtr.Zero) ? null : new Driver(cPtr, false);
  }

  public static Dataset Open(string name, int eAccess) {
    IntPtr cPtr = gdalPINVOKE.Open(name, eAccess);
    return (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true);
  }

  public static Dataset OpenShared(string name, int eAccess) {
    IntPtr cPtr = gdalPINVOKE.OpenShared(name, eAccess);
    return (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true);
  }

  public static Dataset AutoCreateWarpedVRT(Dataset src_ds, string src_wkt, string dst_wkt, int eResampleAlg, double maxerror) {
    IntPtr cPtr = gdalPINVOKE.AutoCreateWarpedVRT(Dataset.getCPtr(src_ds), src_wkt, dst_wkt, eResampleAlg, maxerror);
    return (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true);
  }

}

}
