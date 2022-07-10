namespace Assignment4_Tests
{
    [TestClass]
    public class Assignment4_Tests
    {
        [TestMethod]
        public void Normalizuoja1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = Assignment4.Program.Normalizuoja(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validuoja1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = true;
            var actual = Assignment4.Program.Validuoja(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validuoja2()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCTl    ";
            var expected = false;
            var actual = Assignment4.Program.Validuoja(txt);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void KeiciaGCTiAGG1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-AGG";
            var actual = Assignment4.Program.KeiciaGCTiAGG(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IeskoCAT1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = "Taip";
            var actual = Assignment4.Program.IeskoCAT(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IeskoTrecioIrPenktoSegmento1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = "GAC CGT";
            var actual = Assignment4.Program.IeskoTrecioIrPenktoSegmento(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IeskoTrecioIrPenktoSegmento2()
        {
            var txt = " T CG-TAC- Tta-gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = "TTA TAC";
            var actual = Assignment4.Program.IeskoTrecioIrPenktoSegmento(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsvedaRaidziuKieki1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = 39;
            var actual = Assignment4.Program.IsvedaRaidziuKieki(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsvedaRaidziuKieki2()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT   TTA ";
            var expected = 42;
            var actual = Assignment4.Program.IsvedaRaidziuKieki(txt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IeskoIvestoSegmento1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var ivestasSegmentas = "TAC";
            var expected = "Įvestas segmentas yra DNR grandinėje";
            var actual = Assignment4.Program.IeskoIvestoSegmento(txt, ivestasSegmentas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IeskoIvestoSegmento2()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var ivestasSegmentas = "cGT";
            var expected = "Įvestas segmentas yra DNR grandinėje";
            var actual = Assignment4.Program.IeskoIvestoSegmento(txt, ivestasSegmentas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IeskoIvestoSegmento3()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var ivestasSegmentas = "TTT";
            var expected = "Įvesto segmento nėra DNR grandinėje";
            var actual = Assignment4.Program.IeskoIvestoSegmento(txt, ivestasSegmentas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PridedaIGala1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var ivestasSegmentas = "ATC";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT-ATC";
            var actual = Assignment4.Program.PridedaIGala(txt, ivestasSegmentas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PridedaIGala2()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var ivestasSegmentas = "123";
            var expected = "Segmentą turi sudaryt trys raidės ir tik ATCG";
            var actual = Assignment4.Program.PridedaIGala(txt, ivestasSegmentas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasalinaSegmenta1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var ivestasSegmentas = "TAC";
            var expected = "TCG--GAC--CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = Assignment4.Program.PasalinaSegmenta(txt, ivestasSegmentas);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void PakeiciaSegmenta1()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var pasirinktasSegmentas = "AGA";
            var keitimas = "TAC";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-TAC-GCT";
            var actual = Assignment4.Program.PakeiciaSegmenta(txt, pasirinktasSegmentas, keitimas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeiciaSegmenta2()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var pasirinktasSegmentas = "TAH";
            var keitimas = "AGA";
            var expected = "Segmentą turi sudaryt trys raidės ir tik ATCG";
            var actual = Assignment4.Program.PakeiciaSegmenta(txt, pasirinktasSegmentas, keitimas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeiciaSegmenta3()
        {
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var pasirinktasSegmentas = "AGA";
            var keitimas = "TAH";
            var expected = "Segmentą turi sudaryt trys raidės ir tik ATCG";
            var actual = Assignment4.Program.PakeiciaSegmenta(txt, pasirinktasSegmentas, keitimas);

            Assert.AreEqual(expected, actual);
        }
    }
}