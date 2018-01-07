using hell_triangle_challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hell_triangle_challenge_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarTrianguloDeQuatroLinhas()
        {
            object[] linhas = new object[4];
            linhas[0] = new int[1] { 6 };
            linhas[1] = new int[2] { 3, 5 };
            linhas[2] = new int[3] { 9, 7, 1 };
            linhas[3] = new int[4] { 4, 6, 8, 4 };
            Assert.AreEqual(26, Program.ObterTotalMaximoDoTriangulo(linhas));
        }

        [TestMethod]
        public void TestarTrianguloDeTresLinhas()
        {
            object[] linhas = new object[3];
            linhas[0] = new int[1] { 5 };
            linhas[1] = new int[2] { 4, 6 };
            linhas[2] = new int[3] { 0, 6, 8 };
            Assert.AreEqual(17, Program.ObterTotalMaximoDoTriangulo(linhas));
        }

        [TestMethod]
        public void TestarTrianguloDeDuasLinhas()
        {
            object[] linhas = new object[2];
            linhas[0] = new int[1] { 6 };
            linhas[1] = new int[2] { 5, 7 };
            Assert.AreEqual(13, Program.ObterTotalMaximoDoTriangulo(linhas));
        }
    }
}
