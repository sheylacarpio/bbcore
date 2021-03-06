//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRA.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poblacion
    {
        public int p_id { get; set; }
        public Nullable<short> p_estado { get; set; }
        public string p_numero { get; set; }
        public string p_hl7_id { get; set; }
        public string p_tipo_doc { get; set; }
        public string p_numero_doc { get; set; }
        public Nullable<System.DateTime> p_fecha_reg { get; set; }
        public string p_nombres { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public Nullable<System.DateTime> p_fecha_nac { get; set; }
        public string p_pais_nac { get; set; }
        public string p_sexo { get; set; }
        public Nullable<int> p_ocu_id { get; set; }
        public string p_casa_dir { get; set; }
        public string p_casa_tel { get; set; }
        public string p_trabajo_dir { get; set; }
        public string p_trabajo_tel { get; set; }
        public string p_celular_tel { get; set; }
        public byte[] p_foto { get; set; }
        public string p_email { get; set; }
        public string p_historia { get; set; }
        public string p_abo { get; set; }
        public string p_rh { get; set; }
        public string p_du { get; set; }
        public Nullable<short> p_rh_desde_du { get; set; }
        public string p_abo_inversa { get; set; }
        public string p_rh_inversa { get; set; }
        public string p_fenotipo { get; set; }
        public string p_genotipo_prob { get; set; }
        public string p_cuit { get; set; }
        public Nullable<short> p_predonante { get; set; }
        public Nullable<short> p_club_donantes { get; set; }
        public Nullable<short> p_receptor { get; set; }
        public string p_nota { get; set; }
        public string p_gf { get; set; }
        public Nullable<int> p_pas_id { get; set; }
        public Nullable<int> p_turno { get; set; }
        public Nullable<System.DateTime> p_turno_fecha { get; set; }
        public Nullable<int> p_usr_id_turno { get; set; }
        public Nullable<short> p_afi_id { get; set; }
        public Nullable<short> p_institucion { get; set; }
        public Nullable<short> P_tra { get; set; }
        public Nullable<short> p_tra2 { get; set; }
        public byte[] p_firma { get; set; }
        public Nullable<short> p_recurrente { get; set; }
        public string p_apellidos { get; set; }
        public Nullable<int> p_distrito_id { get; set; }
        public Nullable<System.DateTime> p_fecha_alta { get; set; }
        public string p_ocupacion { get; set; }
        public Nullable<int> o_sed_id { get; set; }
        public Nullable<int> p_sed_id { get; set; }
        public Nullable<int> p_sed_id_proceso { get; set; }
        public Nullable<int> p_test_irradiado { get; set; }
        public Nullable<int> p_test_filtrado { get; set; }
        public Nullable<int> p_test_lavado { get; set; }
        public Nullable<int> p_test_centrifugado { get; set; }
        public string p_procedencia { get; set; }
        public string p_ocupa { get; set; }
        public string p_e_civil { get; set; }
        public string p_l_nacimiento { get; set; }
        public string p_dis_prov_dpt { get; set; }
        public string p_viajes { get; set; }
        public string p_permanencia { get; set; }
    }
}
