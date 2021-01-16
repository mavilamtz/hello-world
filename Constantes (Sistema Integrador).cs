using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Globales
{
   public class Constantes
   {
      public const string APP_ORIGEN = "DIE";
      public const string SEPARADOR_LOG = ">";
      public const int OFICINA_NACIONAL = 100;

      public const string NOMBRE_POLIZA = "VFMMXN";

      public const string VALOR_HISTORICO_CODIGO_HORARIO_TESORERIA = "HORATESO";
      public const string VALOR_HISTORICO_CODIGO_WSPOLIZAS = "WSPOLIZAS";
      public const string VALOR_HISTORICO_CODIGO_WSWRAPPER = "WSWRAPPER";
      public const string VALOR_HISTORICO_CODIGO_WSVALIDABONIFICACION = "WSVALIDABONIFICACION"; //BON
      public const string VALOR_HISTORICO_CODIGO_WSVALIDA = "WSVALIDA";
      public const string VALOR_HISTORICO_CODIGO_WSMAMBUNIVELRIESGO = "WSMMAMBUNIVELRIESGO";
      public const string VALOR_HISTORICO_CODIGO_WSPAYCASH = "WSPAYCASH";
      public const string VALOR_HISTORICO_AHORRO = "AHORRO";
      public const string VALOR_HISTORICO_RUTA_CONTRATOS = "RUTACONTRA";
      public const string VALOR_HISTORICO_RUTA_GUARDA_CONTRATOS = "RUTASAVEC";
      public const string VALOR_HISTORICO_IVA = "IVA";
      public const string VALOR_HISTORICO_DIAS_CONSULTA_CIRCULO_CREDITO = "DIASCC";
      public const string VALOR_HISTORICO_ESTADO_TELECOMM = "ESTADOTLMM";
      public const string VALOR_HISTORICO_FECHA_CIERRE = "FECHACIERRE";
      public const string VALOR_HISTORICO_NUMERO_RECIBOS = "NUMERORECIBOS";

      public const string PAGO_OTROS_INGRESOS = "OTROS INGRESOS";
      public const string PAGO_CUENTA_PUENTE = "CUENTA PUENTE";
      public const string PAGO_REDONDEO = "REDONDEO";
      public const string PAGO_FALTANTE = "FALTANTE";


      public const string TIPO_CABECERO_ORIGINAL = "ORIGINAL";
      public const string TIPO_CABECERO_ADICIONAL = "ADICIONAL";

      public const string STATUS_CABECERO_PAGO_SOBRANTE = "S";
      public const string STATUS_CABECERO_PAGO_PENDIENTE = "P";
      public const string STATUS_CABECERO_PAGO_INICIO = "I";
      public const string STATUS_CABECERO_PAGO_ERROR = "E";
      public const string STATUS_CABECERO_PAGO_TRABAJADO = "T";


      public const string TIPO_MOVIMIENTO_DETALLE_PAGO_MOVIMIENTO = "MOVIMIENTO";
      public const string TIPO_MOVIMIENTO_DETALLE_PAGO_ERROR = "ERROR";
      public const string TIPO_MOVIMIENTO_DETALLE_PAGO_PAGO = "PAGO";
      public const string TIPO_MOVIMIENTO_DETALLE_PAGO_AJUSTE = "AJUSTE";
      public const string TIPO_MOVIMIENTO_DETALLE_PAGO_CANCELACION = "CANCELACION";

      public const string PAGO_APLICADO = "APLICADO";
      public const string PAGO_REFERENCIA_NA = "REFERENCIA N/A";
      public const string PAGO_ERROR = "ERROR";
      public const string PAGO_SOBRANTE = "SOBRANTE";
      public const string PAGO_PARCIAL_PAGADO = "PARCIAL PAGADO";
      public const string PAGO_SIN_CONTRATOS = "NO HAY CONTRATOS EN MAMBU";

      public const double DIAS_CADUCIDAD_AGREGA = 7;

      public const string TIPO_ASIENTO_HEADER = "H";
      public const string TIPO_ASIENTO_DETALLE = "D";

      public const string VALOR_FALSE = "FALSE";
      public const string VALOR_TRUE = "TRUE";


      public const string TIPO_ARCHIVO_TEXTO = "TEXTO";
      public const string TIPO_ARCHIVO_EXCEL = "EXCEL";
      public const string TIPO_ARCHIVO_EXP = "EXP";
      public const string TIPO_ARCHIVO_EXCEL_EXT = "XLSX";
      public const string TIPO_ARCHIVO_TEXTO_EXT = "TXT";
      public const string TIPO_ARCHIVO_EXP_EXT = "EXP";

      public const string TIPO_FILA_HEADER = "H";
      public const string TIPO_FILA_DETAIL = "D";
      public const string TIPO_FILA_FOOTER = "F";

      public const string CARACTER_ESPECIAL_TODOS = "áéíóúÁÉÍÓÚàèìòùÀÈÌÒÙâêîôûÂÊÎÔÛäëïöüÄËÏÖÜÜñÑ|´`¿?¡!-_#$%&/\\()=¨*+[]{}~^`;:<>@°¬,.";
      public const string CARACTER_REEMPLAZO_TODOS = "aeiouAEIOUaeiouAEIOUaeiouAEIOUaeiouAEIOUUnN                                     ";

      public const string ANIO_LARGO_FECHA = "YYYY";
      public const string ANIO_CORTO_FECHA = "YY";
      public const string MES_FECHA = "MM";
      public const string DIA_FECHA = "DD";

      public const string N = "N";
      public const string S = "S";

      public const string TIPO_DATO_TEXTO = "A";
      public const string TIPO_DATO_ENTERO = "I";
      public const string TIPO_DATO_DECIMAL = "M";
      public const string TIPO_DATO_FECHA = "F";


      public const string STATUS_DESEMBOLSO_NO_ENCONTRADO = "0";
      public const string STATUS_DESEMBOLSO_INSERTADO = "1";
      public const string STATUS_DESEMBOLSO_CALCULADO = "2";
      public const string STATUS_DESEMBOLSO_ARCHIVO_GENERADO = "3";
      public const string STATUS_DESEMBOLSO_DESEMBOLSADO = "4";
      public const string STATUS_DESEMBOLSO_CONCILIADO = "5";
      public const string STATUS_DESEMBOLSO_CAMBIO_REFERENCIA = "6";
      public const string STATUS_DESEMBOLSO_CAMBIO_REFERENCIA_ARCHIVO_GENERADO = "7";


      public const string STATUS_CIERRE_PROCESANDO = "P";
      public const string STATUS_CIERRE_ERROR = "E";
      public const string STATUS_CIERRE_TERMINADO = "T";
      public const string STATUS_CIERRE_SIN_PROCESAR = "N";


      public const string STATUS_CONCILIACION_DETALLE_RECIBIDA = "1";

      public const string MEDIO_DESEMBOLSO_DIE = "DIE";
      public const string MEDIO_DESEMBOLSO_TRANSFERENCIA = "TRANSFERENCIA";
      public const string MEDIO_DESEMBOLSO_CHEQUE = "CHEQUE";

      public const string ESTATUS_BANCO_ACTIVO = "A";
      public const string ESTATUS_USUARIO_ACTIVO = "A";


      //public const String RUTA_WS_WRAPPER = "http://localhost:61252/WSWrapper.asmx?wsdl";

      public const String VALOR_VERDADERO = "TRUE";


      public const String CAMBIO_REFERENCIA = "CAMBIO_REFERENCIA_";
      public const String TIPO_REFERENCIA_DESEMBOLSO = "DESEMBOLSO";
      public const String TIPO_REFERENCIA_BONIFICACION = "BONIFICACION";

      public const string ACCESORIO_ADMINISTRATIVO = "ADMINISTRATIVO";
      public const string ACCESORIO_DESEMBOLSO = "DESEMBOLSO";

      public const String VALOR_SI = "S";
      public const String VALOR_NO = "N";

      public const string DIMENSION_FINANCIERA_001 = "DIM001";
      public const string DIMENSION_FINANCIERA_002 = "DIM002";

      public const String TIPO_PRODUCTO_DESCRIPCION_PRINCIPAL = "PRINCIPAL";
      public const String TIPO_PRODUCTO_DESCRIPCION_SECUNDARIO = "SECUNDARIO";

      public const String TIPO_PRODUCTO_PRINCIPAL = "P";
      public const String TIPO_PRODUCTO_SECUNDARIO = "S";

      public const String FORMATO_FECHA_YYYY_MM_DD = "yyyy-MM-dd";
      public const String FORMATO_FECHA_DD_MM_YYYY = "dd/MM/yyyy";
      public const String FECHA_VACIA_MAMBU = "01/01/0001 12:00:00 a.m.";
      public const String FECHA_VACIA_MAMBU_A = "19000101";

      public const string PERIODO_AGREGA_DIA = "DIA";
      public const string PERIODO_AGREGA_MES = "MES";

      public const string NADA_TEXTO_CONTRATO = "-";
      public const string DOMICILIO_VF_CONTRATO = "SEVILLA NO. 40 PISO 1, COL. JUAREZ, C.P. 06600, MEXICO, D.F.";
      public const string LINEA_FIRMA_CONTRATO = "_______________________________________";
      public const string TEXTO_AVAL_CONTRATO = "Nombre(s), Apellidos completo(s) y Firma del \"AVAL\" ";
      public const string GRUPO_SOLIDARIO_CONTRATO = "GS";
      public const string GRUPO_SOLIDARIO_FLAT_CONTRATO = "GS FLAT";
      public const string UDE_CONTRATO = "UDE";
      public const string UDE_2_0_CONTRATO = "UDE 2.0";
      public const string EXTENSION_DOCUMENTOS = ".docx";

      public const String VALOR_UDE = "UDE";
      public const string AVALISTAS_AVALISTAS = "los avalistas";
      public const string AVALISTAS_OBLIGADOS = "los obligados solidarios";


      public const string PRODUCTO_BANCA_COMUNAL = "BANCA COMUNAL";
      public const string PRODUCTO_BANCA_COMUNAL_MENSUAL = "BANCA COMUNAL MENSUAL";
      public const string PRODUCTO_GS_FLAT = "GRUPO SOLIDARIO (FLAT)";
      public const string PRODUCTO_GS_SI = "GRUPO SOLIDARIO (SI)";
      public const string PRODUCTO_GS_V = "GRUPO SOLIDARIO (SI) AL VENCIMIENTO";
      public const string PRODUCTO_CREDI_EDUCACION = "EDUCACIÓN";
      public const string PRODUCTO_VIVIENDA = "VIVIENDA";
      public const string PRODUCTO_EMPRENDEDOR = "EMPRENDEDOR";
      public const string PRODUCTO_CREDI_MUEBLE = "MUEBLE";
      public const string PRODUCTO_INDIVIDUAL = "INDIVIDUAL";
      public const string PRODUCTO_SECUNDARIO = "SECUNDARIO";
      public const string PRODUCTO_INDIVIDUAL_AGRO = "INDIVIDUAL-AGRO";
      public const string PRODUCTO_TEMPORADA = "TEMPORADA";
      public const string PRODUCTO_COLATERAL = "COLATERAL";
      public const string PRODUCTO_UDE = "UDE";
      public const string PRODUCTO_UDE_2_0 = "UDE 2.0";
      public const string PRODUCTO_FLAT = "FLAT";
      public const string PRODUCTO_GRUPAL = "GRUPAL";
      public const string PRODUCTO_SOLIDARIO = "SOLIDARIO";
      public const string PRODUCTO_REACTIVACION = "REACTIVACION";



        public const string PERIODO_UN_PAGO = "UN SOLO PAGO";
      public const string PERIODO_SEMANAL = "SEMANAL";
      public const string PERIODO_CATORCENAL = "CATORCENAL";
      public const string PERIODO_QUINCENAL = "QUINCENAL";
      public const string PERIODO_MENSUAL = "MENSUAL";
      public const string PERIODO_MENSUAL_LUNAR = "MENSUAL LUNAR";
      public const string PERIODO_BIMESTRAL = "BIMESTRAL";
      public const string PERIODO_TRIMESTRAL = "TRIMESTRAL";
      public const string PERIODO_CUATRIMESTRAL = "CUATRIMESTRAL";
      public const string PERIODO_SEMESTRAL = "SEMESTRAL";
      public const string PERIODO_AL_VENCIMIENTO = "AL VENCIMIENTO";

      public const string INICIO_BANCO_BANAMEX = "BNMX";
      public const string INICIO_BANCO_BANCOMER = "BBVA";
      public const string INICIO_BANCO_BANCOMER_TPV = "BBPV";
      public const string INICIO_BANCO_BANCOPEL = "BCPP";
      public const string INICIO_BANCO_BANORTE = "BNRT";
      public const string INICIO_BANCO_BANSEFI = "BNSF";
      public const string INICIO_BANCO_HSBC = "HSBC";
      public const string INICIO_BANCO_SANTANDER = "STDR";
      public const string INICIO_BANCO_7ELEVEN = "7ELE";
      public const string INICIO_BANCO_TELECOMM = "TLMM";

      public const string ERROR_APLICADO = "APLICADO";
      public const string ERROR_NO_APLICADO = "NO APLICADO";
      public const string ERROR = "ERROR";
      public const string PENDIENTE = "PENDIENTE";
      public const string PROCESADO = "PROCESADO";

      public const double COMISION_DESEMBOLSO = 2.5;
      public const decimal LIMITE_SOBRANTE_PAGO = 30;
      public const decimal LIMITE_FALTANTE_PAGO = 30;
      public const decimal MINIMO_FALTANTE_PAGO = 1;
      public const double CUOTA_SEMANAL_SEGURO_FAMILIAR = 3.0;

      public const int NUMERO_AVALES_PERMITIDO = 2;

      public const double CUOTA_SEMANAL_AHORRO = 8;
      public const double COMISION_DESEMBOLSO_PORCENTAJE = 0.025;


      public const string PERIODO_CATEGORIA = "PERIODOCAT";



      public const decimal PORCENTAJE_CONTROL_AHORROS = 0.10M;
      public const double PORCENTAJE_BONIFICA_015 = 0.15;
      public const double PORCENTAJE_BONIFICA_017 = 0.17;
      public const double PORCENTAJE_BONIFICA_020 = 0.2;
      public const string FACTOR_BONIFICACION = "FACTORBONI";



      public const string NO_APLICA = "No Aplica";
      public const string CLAUSULA_NOVENA = "Cláusula Novena";
      public const string GRATIS = "Gratis";
      public const string NOMBRE_ASEGURADORA = "Chubb de México";
      public const string SEGURO_INDIVIDUAL = "Seguro de Forma Individual";



      public const string CONTRATO_INDIVIDUAL = "5926-439-021860/01-05452-0615";
      public const string CONTRATO_FLAT = "5926-439-021861/01-05453-0615";
      public const string CONTRATO_GRUPAL = "5926-439-021862/01-05454-0615";
      public const string CONTRATO_UDE_2_0 = "5926-439-021863/01-05455-0615";
      public const string CONTRATO_UDE = "5926-439-021864/01-05456-0615";


      public const int ESTATUS_SOLICITUD_CC_INICIO = 0;


      public const string BANCO_BANAMEX = "BANAMEX";
      public const string BANCO_BANCOMER = "BANCOMER";
      public const string BANCO_BANCOMER_TPV = "BANCOMER TPV";
      public const string BANCO_BANCOPEL = "BANCOPPEL";
      public const string BANCO_BANORTE = "BANORTE";
      public const string BANCO_BANSEFI = "BANSEFI";
      public const string BANCO_HSBC = "HSBC";
      public const string BANCO_SANTANDER = "SANTANDER";
      public const string BANCO_7ELEVEN = "7ELEVEN";
      public const string BANCO_TELECOMM = "TELECOMM";
      public const string BANCO_PAYCASH = "PAYCASH";

      public const string DIA_dd = "dd";
      public const string MES_MMMM = "MMMM";
      public const string ANIO_yyyy = "yyyy";

      public const string TIPO_LAYOUT_CONCILIACION = "CONCIL";
      public const string TIPO_LAYOUT_PAGO = "PAGO";

      public const string CONTRASENA_DOCUMENTOS_WORD = "S1st3m4zM4wbu";


      public const string ESTADO_AGUASCALIENTES = "AGUASCALIENTES";
      public const string ESTADO_BAJA_CALIFORNIA = "BAJA CALIFORNIA";
      public const string ESTADO_BAJA_CALIFORNIA_SUR = "BAJA CALIFORNIA SUR";
      public const string ESTADO_CAMPECHE = "CAMPECHE";
      public const string ESTADO_CHIAPAS = "CHIAPAS";
      public const string ESTADO_CHIHUAHUA = "CHIHUAHUA";
      public const string ESTADO_CIUDAD_DE_MEXICO = "CIUDAD DE MÉXICO";
      public const string ESTADO_COAHUILA = "COAHUILA";
      public const string ESTADO_COLIMA = "COLIMA";
      public const string ESTADO_DURANGO = "DURANGO";
      public const string ESTADO_ESTADO_DE_MEXICO = "ESTADO DE MÉXICO";
      public const string ESTADO_EXTRANJERO = "EXTRANJERO";
      public const string ESTADO_GUANAJUATO = "GUANAJUATO";
      public const string ESTADO_GUERRERO = "GUERRERO";
      public const string ESTADO_HIDALGO = "HIDALGO";
      public const string ESTADO_JALISCO = "JALISCO";
      public const string ESTADO_MICHOACAN = "MICHOACAN";
      public const string ESTADO_MORELOS = "MORELOS";
      public const string ESTADO_NAYARIT = "NAYARIT";
      public const string ESTADO_NUEVO_LEON = "NUEVO LEÓN";
      public const string ESTADO_OAXACA = "OAXACA";
      public const string ESTADO_PUEBLA = "PUEBLA";
      public const string ESTADO_QUERETARO = "QUERÉTARO";
      public const string ESTADO_QUINTANA_ROO = "QUINTANA ROO";
      public const string ESTADO_SAN_LUIS_POTOSI = "SAN LUIS POTOSÍ";
      public const string ESTADO_SINALOA = "SINALOA";
      public const string ESTADO_SONORA = "SONORA";
      public const string ESTADO_TABASCO = "TABASCO";
      public const string ESTADO_TAMAULIPAS = "TAMAULIPAS";
      public const string ESTADO_TLAXCALA = "TLAXCALA";
      public const string ESTADO_VERACRUZ = "VERACRUZ";
      public const string ESTADO_YUCATAN = "YUCATAN";
      public const string ESTADO_ZACATECAS = "ZACATECAS";


      public const string ESTADO_CC_AGUASCALIENTES = "AGS";
      public const string ESTADO_CC_BAJA_CALIFORNIA = "BC";
      public const string ESTADO_CC_BAJA_CALIFORNIA_SUR = "BCS";
      public const string ESTADO_CC_CAMPECHE = "CAMP";
      public const string ESTADO_CC_CHIAPAS = "CHIS";
      public const string ESTADO_CC_CHIHUAHUA = "CHIH";
      public const string ESTADO_CC_CIUDAD_DE_MEXICO = "DF";
      public const string ESTADO_CC_COAHUILA = "COAH";
      public const string ESTADO_CC_COLIMA = "COL";
      public const string ESTADO_CC_DURANGO = "DGO";
      public const string ESTADO_CC_ESTADO_DE_MEXICO = "MEX";
      public const string ESTADO_CC_GUANAJUATO = "GTO";
      public const string ESTADO_CC_GUERRERO = "GRO";
      public const string ESTADO_CC_HIDALGO = "HGO";
      public const string ESTADO_CC_JALISCO = "JAL";
      public const string ESTADO_CC_MICHOACAN = "MICH";
      public const string ESTADO_CC_MORELOS = "MOR";
      public const string ESTADO_CC_NAYARIT = "NAY";
      public const string ESTADO_CC_NUEVO_LEON = "NL";
      public const string ESTADO_CC_OAXACA = "OAX";
      public const string ESTADO_CC_PUEBLA = "PUE";
      public const string ESTADO_CC_QUERETARO = "QRO";
      public const string ESTADO_CC_QUINTANA_ROO = "QROO";
      public const string ESTADO_CC_SAN_LUIS_POTOSI = "SLP";
      public const string ESTADO_CC_SINALOA = "SIN";
      public const string ESTADO_CC_SONORA = "SON";
      public const string ESTADO_CC_TABASCO = "TAB";
      public const string ESTADO_CC_TAMAULIPAS = "TAMP";
      public const string ESTADO_CC_TLAXCALA = "TLAX";
      public const string ESTADO_CC_VERACRUZ = "VER";
      public const string ESTADO_CC_YUCATAN = "YUC";
      public const string ESTADO_CC_ZACATECAS = "ZAC";


      public const int ESTATUS_SOLICITUD_ERROR = -1;
      public const int ESTATUS_SOLICITUD_INICIO = 1;
      public const int ESTATUS_SOLICITUD_CONSULTADO = 2;
      public const int ESTATUS_SOLICITUD_PDF_GENERADO = 3;
      public const int ESTATUS_SOLICITUD_PDF_DESCARGADO = 4;


      public const string NO_CAPTURADA = "NO_CAPTURADA";
      public const string NO_CAPTURADO = "NO_CAPTURADO";



      public const string PROCESO_EXITOSO = "EXITOSO";


      public const string GARANTIA_COMPARTIDA_CON = "NOTA: Garantia compartida con";

      public const string TIPO_CABECERO = "ORIGINAL";


      public const string CONCILIACION_PRESTAMO = "PRESTAMO";
      public const string CONCILIACION_BONIFICACION = "BONIFICACION";


      public const string RUTA_BACKUP_MySQL = "RUTABAKUPMySQL";

      public const string ANIO = "ANIOS";
      public const string MES = "MESES";


      public const string FONDEADOR = "FONDEADOR";
      public const string FONDEADOR_MAMBU_FOMMUR = "1.- FOMMUR";
      public const string FONDEADOR_MAMBU_FINAFIM = "2.- FINAFIM";

      public const string MENSAJE_LOG = " Mensaje: ";


      public const string VALOR_HISTORICO_DIASSEMANAL1 = "DIASSEMANAL1";
      public const string VALOR_HISTORICO_DIASSEMANAL2 = "DIASSEMANAL2";

      public const string VALOR_HISTORICO_DIASCATORCENA1 = "DIASCATORCENA1";
      public const string VALOR_HISTORICO_DIASCATORCENA2 = "DIASCATORCENA2";

      public const string VALOR_HISTORICO_DIASMENSUAL1 = "DIASMENSUAL1";
      public const string VALOR_HISTORICO_DIASMENSUAL2 = "DIASMENSUAL2";

      public const string ESTATUS_BONIFICACION_ABIERTO = "ABIERTO";
      public const string ESTATUS_BONIFICACION_CONVENIO = "CONVENIO";
      public const string ESTATUS_BONIFICACION_CERRADO = "CERRADO";
      public const string ESTATUS_BONIFICACION_COBRANZA30PLUS = "COBRANZA 30 PLUS";
      public const string ESTATUS_BONIFICACION_PENDIENTE = "PENDIENTE";
      public const string ESTATUS_BONIFICACION_ACLARACION_CARTERA = "ACLARACION CARTERA";
      public const string ESTATUS_BONIFICACION_CERRADO_POR_NO_PAGO = "CERRADO POR NO PAGO";


      public const string BONIFICACION_MOTIVO_CAMBIO = "MOTIVO_CAMBIO";
      public const string BONIFICACION_EST_APLICA = "EST_APLICA";
      public const string BONIFICACION_ID_Credito = "ID_Credito";
      public const string BONIFICACION_NO = "NO";
      public const string BONIFICACION_SI = "SI";
      public const string BONIFICACION_VF = "VF";


      public const string CONTROL_PAGOS_AHORROS_NUMERO_CLIENTE = "Número Cliente";
      public const string CONTROL_PAGOS_AHORROS_NOMBRE_CLIENTE = "Nombre Cliente";
      public const string CONTROL_PAGOS_AHORROS_MONTO_OTORGADO = "Monto Otorgado";
      public const string CONTROL_PAGOS_AHORROS_SALDO_TOTAL_PAGAR = "Saldo Total Pagar";
      public const string CONTROL_PAGOS_AHORROS_BASE_AHORRO = "Base Ahorro";
      public const string CONTROL_PAGOS_AHORROS_TOTAL = "TOTAL";
      public const string CONTROL_PAGOS_AHORROS_FALTAS_PAGAR = "Faltas Pagar";

      public const string PASSWORD_EDICION_ARCHIVOS_EXCEL = "$1st3M4zñ";

      public const string VALOR_CONTROL_PAGOS = "CONTROL_PAGOS";
      public const string VALOR_CONTROL_AHORRROS = "CONTROL_AHORROS";
      public const string TITULO_CONTROL_PAGOS = "CONTROL DE PAGOS";
      public const string TITULO_CONTROL_AHORRROS = "CONTROL DE AHORROS";

      public const string ARCHIVO_CONTROL_PAGOS = "CONTROL_DE_PAGOS";
      public const string ARCHIVO_CONTROL_AHORRROS = "CONTROL_DE_AHORROS";



      public enum Abecedario
      {
         A = 0,
         B,
         C,
         D,
         E,
         F,
         G,
         H,
         I,
         J,
         K,
         L,
         M,
         N,
         O,
         P,
         Q,
         R,
         S,
         T,
         U,
         V,
         W,
         X,
         Y,
         Z
      }



      //BONIFICACIONES
      public const string VALIDADOR_CREDITO = "CREDTIO";
      public const string VALIDADOR_BONIFICACION = "BONIFICACION";
      public const string BONIFICACION_PORCENTAJE_PAGO = "BONIFICACION_PORCENTAJE_PAGO";
      public const string BONIFICACION_FECHA_BONIFICACION = "FECHABONI";
      public const string BONIFICACION_NO_PROCEDE = "Bonificación No Procede";
      public const string TRAMITAR_BONIFICACION = "Tramitar Bonificación";
      public const string PORCENTAJE_MINIMO_CLIENTES_RENOVACION = "PORCENTAJE_MINIMO_CLIENTES_RENOVACION";

      // REFINANCIAMIENTO
      public const string COMISION_REFINANCIAMIENTO = "REFINANCIAMIENTO";


      //SEGUROS
      public const string SEGURO_BASICO = "SEGURO BASICO";
      public const string SEGURO_FAMILIAR = "SEGURO FAMILIAR";
      public const string SEGURO_BASICO_ID_FIELD = "Seguro_Basico_Cuentas_de_Préstam";
      public const string SEGURO_FAMILIAR_ID_FIELD = "Seguro_Familiar_Cuentas_de_Prést";
      public const string SEGURO_BASICO_DESCONTADO_TIPO = "DESCONTADO";
      public const string SEGURO_BASICO_DIFERIDO_TIPO = "DIFERIDO";
      public const string SEGURO_FAMILIAR_DESCONTADO_TIPO = "DESCONTADO";
      public const string SEGURO_FAMILIAR_DIFERIDO_TIPO = "DIFERIDO";
      public const string SEGURO_BASICO_DESCONTADO_KEY = "8a8187566fe8c9f1016fe96c8cd70357";
      public const string SEGURO_BASICO_DIFERIDO_KEY = "8a8187566fe8c9f1016fe96c746b0351";
      public const string SEGURO_FAMILIAR_DESCONTADO_KEY = "8a8187566fe8c9f1016fe96c8cd50355";
      public const string SEGURO_FAMILIAR_DIFERIDO_KEY = "8a8187566fe8c9f1016fe96c8cd50353";
      public const string SEGURO_FAMILIAR_NO_LO_QUIERE = "NO LO QUIERE";
      public const int PERIODO_MENSUAL_VALOR = 30;
      public const string CODIGO_SERVICIOS_EXTERNOS_CB = "VSF019";


      //ACCESORIOS
      public const string CODIGO_ACCESORIOS_REFINANCIAMIENTO = "REFINANCIAMIENTO";
      public const string CODIGO_ACCESORIOS_DISPOSICION = "DISPOSICION";
      public const string CODIGO_ACCESORIOS_SEGURO_BASICO = "SEGUROBASICO";
      public const string CODIGO_ACCESORIOS_SEGURO_FAMILIAR = "SEGUROFAMILIAR";
      public const string CODIGO_ACCESORIOS_COMISION = "COMISION";
      public const string CODIGO_ACCESORIOS_BONIFICACION = "BONIFICACION";
      public const string CODIGO_ACCESORIOS_SIGNO_SUMA = "SUMA";
      public const string CODIGO_ACCESORIOS_SIGNO_RESTA = "RESTA";

      public const string PRODUCTO_REPORTA_SEGURO = "SEGURO NARANJA";


      public const string LIMITE_CONSULTA = "limit=1000";
      public const string OFFSET_CONSULTA = "offset=";
      public const string METODO_POST = "POST";

      public const string TIPO_SEGURO_PROTEGE = "VF Protege";
      public const string TIPO_SEGURO_PROTEGE_Plus = "VF Protege Plus";

      public const string PLAZO_SEGURO_ANUAL = "Anual";
      public const string PLAZO_SEGURO_SEMESTRAL = "Semestral";
      public const string PLAZO_SEGURO_TRIMESTRAL = "Trimestral";


        public const string TIPO_CLIENTE_AVAL = "Aval";
        public const string TIPO_CLIENTE_PROSPECTO = "Prospecto";
        public const string TIPO_CLIENTE_CLIENTE = "Cliente";
        public const string TIPO_CLIENTE_ASEGURADO = "Asegurado";
        public const string TIPO_CLIENTE_CONYUGE = "Conyuge";
        public const string TIPO_CLIENTE_VERIFICAR_ROL = "VerificarRoles";


        public const string FRECUENCIA_PAGO_NA = "NA";

        public const string TIPO_DEVENGADO_FLAT = "FLAT";
        public const string TIPO_DEVENGADO_INSOLUTO = "INSOLUTO";

        public const int BONIFICACION_VALOR_MES = 31;

    }
}
