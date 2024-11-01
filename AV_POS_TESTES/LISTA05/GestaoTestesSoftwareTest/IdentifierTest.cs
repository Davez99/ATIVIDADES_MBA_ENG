using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Xunit;

namespace GestaoTestesSoftwareTest
{
    public class IdentifierTest
    {

        /*
            Camada de teste tem por objetivo criar testes de validação para a classe Identifier 

            utilizando metodo TDD

            Irei utilizar o metodo de validação AAA (Arrange, Assert e act)

            As convenções são do C# (C sharp)

            stacks utilizadas: .NET 8, xUnit

            CASOS DE TESTES:
            Entrada: “aaa”      Saída: TRUE;    (CT1)
            Entrada: “1aa”      Saída: FALSE;   (CT2)
            Entrada: “a2a”      Saída: TRUE;    (CT3)
            Entrada: “a_a”      Saída: FALSE;   (CT4)
            Entrada: “a”        Saída: TRUE;    (CT5)
            Entrada: “”         Saída: FALSE;   (CT6)
            Entrada: “aaaBBB”   Saída: TRUE;    (CT7)
            Entrada: “aaaBBB7”  Saída: FALSE;;  (CT8)

        */

        [Fact]
        public void CT1()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "aaa";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }
        
        [Fact]
        public void CT2()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "1aa";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

        [Fact]
        public void CT3()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "a2a";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

        [Fact]
        public void CT4()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "a_a";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

        [Fact]
        public void CT5()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "a";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

        [Fact]
        public void CT6()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = String.Empty;

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

        [Fact]
        public void CT7()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "aaaBBB";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

        [Fact]
        public void CT8()
        {
            //ARRANGE
            var casoTeste = new Identifier();
            var entrada = "aaaBBB7";

            //ASSERT
            var resultado = casoTeste.ValidateIdentifier(entrada);

            //ACT
            Assert.True(resultado);
        }

    }
}