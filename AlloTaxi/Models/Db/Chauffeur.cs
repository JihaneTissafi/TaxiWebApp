//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlloTaxi.Models.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Chauffeur
    {
        public int Id { get; set; }
        public string Numero_Taxi { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
        public string Numero_Telephone { get; set; }

        [NotMapped]
        public List<Chauffeur> CollectionChauffeur = new List<Chauffeur>();
    }
}
