//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAppHero
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sacoche
    {
        public string nom { get; set; }
        public Nullable<int> lvlObj { get; set; }
        public Nullable<int> quantite { get; set; }
        public string description { get; set; }
        public Nullable<float> prix { get; set; }
        public int id_sacoche { get; set; }
        public Nullable<int> id_hero { get; set; }
    
        public virtual Hero Hero { get; set; }
    }
}