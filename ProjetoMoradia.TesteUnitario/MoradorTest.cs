using Xunit;
using ProjetoMoradia.Models;
using System;

namespace ProjetoMoradia.TesteUnitario;

public class MoradorTest
{
    [Fact]
    public void MoradorDeveTerDataNascimentoEsperada()
    {
        //Preparando - Arrange
        var dataNascimentoEsperada = "04/04/2004";
        var morador = new Morador("Giovanni", "44455566678", dataNascimentoEsperada);
        //DataNascimento - Act
        var dataNascimento = morador.GetDataDeNascimento();

        Assert.Equal(dataNascimentoEsperada, dataNascimento.ToString("dd/MM/yyyy"));
    }
     [Fact]
    public void MoradorNaoDeveTerDataNascimentoMaiorQueADataAtual()
    {
        //Preparando - Arrange
        var dataNascimento = "29/04/2022";
        var morador = new Morador("Giovanni", "44455566678", dataNascimento);
        //DataNascimento - Act
        var dataNascimentosalva = morador.GetDataDeNascimento().ToString("dd/MM/yyyy");
        
        
        //"datanascimento" é a data que foi colocada na primeira linha(ela precisa ser convertida para "DateTime")
        //se a função la na classe "Morado.cs" funcionar, "dataNascimentoAtual" vai tero mesmo valor que a "dataNascimento"
        
        Assert.Equal(dataNascimento, dataNascimentosalva);
    }
}