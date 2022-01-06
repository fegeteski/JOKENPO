using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOKENPÔ
{
    public partial class jokenpo : Form
    {
        Image[] img_cpu = new Image[]
        {
            Properties.Resources.PEDRA_2,
            Properties.Resources.PAPEL_2,
            Properties.Resources.TESOURA_2
        };


        public jokenpo()
        {
            InitializeComponent();
        }

        private void click_jogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            pic_jogador.Image = bt.BackgroundImage;
            Jogada jogada_jogador = retorna_jogador(Convert.ToInt32(bt.Tag));
            Jogada jogada_cpu = retorna_cpu();
            Resultado resultado = Ganhador(jogada_jogador, jogada_cpu);

            if (resultado == Resultado.vitoria_jogador)
            {
               pt_jogador.Text = (int.Parse(pt_jogador.Text) +1).ToString();
            }

            else if (resultado == Resultado.vitoria_cpu)
            {
                pt_cpu.Text = (int.Parse(pt_cpu.Text) +1).ToString();
            }

        }

        private Jogada retorna_jogador (int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada retorna_cpu()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            pic_maq.Image = img_cpu[escolha];
            return (Jogada)escolha;
        }

        private Resultado Ganhador(Jogada jogador, Jogada cpu)
        {
            if (jogador == Jogada.Pedra)
            {
                if (cpu == Jogada.Papel)
                {
                    return Resultado.vitoria_cpu;
                }
                else if (cpu == Jogada.Tesoura)
                {
                    return Resultado.vitoria_jogador;
                }
            }

            if (jogador == Jogada.Papel)
            {
                if (cpu == Jogada.Pedra)
                {
                    return Resultado.vitoria_jogador;
                }
                else if (cpu == Jogada.Tesoura)
                {
                    return Resultado.vitoria_cpu;
                }
            }

            if (jogador == Jogada.Tesoura)
            {
                if (cpu == Jogada.Pedra)
                {
                    return Resultado.vitoria_cpu;
                }
                else if (cpu == Jogada.Papel)
                {
                    return Resultado.vitoria_jogador;
                }
            }

            return Resultado.empate;
        }

    }

    enum Jogada
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    enum Resultado
    {
        vitoria_jogador,
        vitoria_cpu,
        empate
    }

}
