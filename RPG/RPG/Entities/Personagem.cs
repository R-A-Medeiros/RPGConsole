using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities;
internal abstract class Personagem
{
    private string Name { get; set; } = string.Empty;
    private int Hp { get; set; }
    private int Mp { get; set; }
    private int AttackPower { get; set; }
    private int Defesa { get; set; }
    private int Nivel { get; set; }
    private int Forca {  get; set; }
    private int Hit {  get; set; }
    private int Magia { get; set; }
    private int DefesaMagica { get; set; }
    private int Velocidade { get; set; }
    private int Evasiva { get; set; }
    private int Estamina { get; set; }
    private List<Equipamento>? equipamentos { get; set; }
    private List<Tecnica>? tecnicas { get; set; }

    
}
