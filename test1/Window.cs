using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Windowing.Desktop;
using LearnOpenTK.Common;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Mathematics;

namespace test1
{   
    static class Warna
    {
        public const string col = "../../../shader/";
    }
    internal class Window : GameWindow{
        Shader _shader;
       
        List<Asset_3D> _object = new List<Asset_3D>();
        List<Asset_3D> __object = new List<Asset_3D>();
        Camera _camera;
        bool _firstMove = true;
        Vector2 _lastposition;
        Vector3 _objectposition = new Vector3(0.0f,0.0f,0.0f);
        float _rotationSpeed = 0.2f;
        float _time;
        float degr = 0;
        bool belakang = false;
        int i = 10;
        float _intime ;
        float temp = 0;
        bool tembakdepan = false;
        Asset_3D kubus = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D badan = new Asset_3D(new Vector3(0.0f, 0.0f, 0.0f));
        Asset_3D pantat = new Asset_3D(new Vector3(0.1f, 0.2f, 0.3f));
        Asset_3D tangankanan = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D titiktengah = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D tangankiri = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D kubus2 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D kubus3 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D kubus4 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D kubus5 = new Asset_3D(new Vector3(0, 0, 0));
        Asset_3D kubus6 = new Asset_3D(new Vector3(0, 0, 0));
        Asset_3D leher = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D telapaktkanan = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D telapaktkiri = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D kakikanan = new Asset_3D(new Vector3(0.1f, 0.2f, 0.3f));
        Asset_3D kakikiri = new Asset_3D(new Vector3(0.1f, 0.2f, 0.3f));
        Asset_3D buntut = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D titikbuntut = new Asset_3D(new Vector3(0f, 0f, 0f));
        Asset_3D antena = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D antenakanan = new Asset_3D(new Vector3(0.2f, 0.5f, 0.1f));
        Asset_3D tanah = new Asset_3D(new Vector3(0.54f, 0.6f, 0.35f));

        Asset_3D tanah1 = new Asset_3D(new Vector3(0.7f, 5f, 0.8f));
        Asset_3D bulan1 = new Asset_3D(new Vector3(1, 0, 1));
        Asset_3D bulan2 = new Asset_3D(new Vector3(0, 1, 1));
        Asset_3D bulan3 = new Asset_3D(new Vector3(0, 1, 0));
        Asset_3D bulan4 = new Asset_3D(new Vector3(0.5f, 0.1f, 1));
        Asset_3D utama = new Asset_3D(new Vector3(0.1f, 0.1f, 0.7f));
        Asset_3D kaca = new Asset_3D(new Vector3(0f, 1.0f, 1.0f));
        Asset_3D tanganKiri1 = new Asset_3D(new Vector3(0.6f, 0.2f, 1f));
        Asset_3D tanganKiri2 = new Asset_3D(new Vector3(0.6f, 0.2f, 1f));
        Asset_3D tanganKiri3 = new Asset_3D(new Vector3(0.6f, 0.2f, 1f));
        Asset_3D Canon1 = new Asset_3D(new Vector3(1f, 1f, 1f));
        Asset_3D tanganKanan1 = new Asset_3D(new Vector3(0.6f, 0.2f, 1f));
        Asset_3D tanganKanan2 = new Asset_3D(new Vector3(0.6f, 0.2f, 1f));
        Asset_3D tanganKanan3 = new Asset_3D(new Vector3(0.6f, 0.2f, 1f));
        Asset_3D Canon2 = new Asset_3D(new Vector3(1f, 1f, 1f));
        Asset_3D Mata1 = new Asset_3D(new Vector3(1f, 0f, 0f));
        Asset_3D Mata2 = new Asset_3D(new Vector3(1f, 0f, 0f));
        Asset_3D mulut1 = new Asset_3D(new Vector3(1f, 0.1f, 0.1f));
        Asset_3D antena11 = new Asset_3D(new Vector3(1f, 1f, 1f));
        Asset_3D ujung = new Asset_3D(new Vector3(0, 0, 1));
        Asset_3D bintang1 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang2 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang3 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang4 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang5 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang6 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang7 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang8 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang9 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang10 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang11 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D bintang12 = new Asset_3D(new Vector3(1, 1, 1));
        Asset_3D peluru1 = new Asset_3D(new Vector3(1,0,0));
        Asset_3D peluru2 = new Asset_3D(new Vector3(1, 0, 0));
        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnLoad()
        {
            base.OnLoad();

            
            GL.ClearColor(0f, 0f, 0f, 0f);
            GL.Enable(EnableCap.DepthTest);
            
            kaca.createEllipsoid2(0.3f, 0.15f, 0.3f, 0, 0.05f, 0, 72, 24);
            utama.createEllipsoid2(0.5f, 0.1f, 0.5f, 0, 0, 0, 72, 24);
            Mata1.createCuboid(0.075f, 0.2f, 0.18f, 0.1f, 0.05f, 0.02f);
            Mata2.createCuboid(-0.075f, 0.2f, 0.18f, 0.1f, 0.05f, 0.02f);
            mulut1.createEllipsoid(0.1f, 0.2f, 0.01f, 0, 0.18f, 0.29f,72,24);
            tanganKiri1.createEllipsoid2(0.03f, 0.03f, 0.2f, 0.51f, 0, 0.2f, 72, 24);
            tanganKiri2.createEllipsoid2(0.03f, 0.03f, 0.2f, 0.63f, 0, 0.27f, 72, 24);
            tanganKiri3.createCone(0.05f,0.2f,0.68f,0.025f, 0.15f, 0.025f, 72,24);
            mulut1.rotate(kaca._centerPosition, mulut1._euler[1], 330f);
            tanganKiri2.rotate(kaca._centerPosition, tanganKiri2._euler[1], 330f);
            tanganKiri3.rotate(kaca._centerPosition, tanganKiri3._euler[2], 275f);
            Canon1.createEllipsoid2(0.03f, 0.03f, 0.4f, 0.4f, 0, 0f, 72, 24);
            Mata1.rotate(kaca._centerPosition, Canon1._euler[1], 330f);
            Mata2.rotate(kaca._centerPosition, Canon1._euler[1], 330f);
            Canon1.rotate(kaca._centerPosition, Canon1._euler[1], 330f);
            tanganKanan1.createEllipsoid2(0.03f, 0.03f, 0.2f, -0.6f, 0, 0.25f, 72, 24);
            tanganKanan2.createEllipsoid2(0.03f, 0.03f, 0.2f, -0.51f, 0, 0.153f, 72, 24);
            tanganKanan3.createCone(0.04f, 0.225f, 0.65f, 0.025f, 0.15f, 0.025f, 72, 24);
            tanganKanan2.rotate(kaca._centerPosition, tanganKanan2._euler[1], 304f);
            tanganKanan1.rotate(kaca._centerPosition, tanganKanan1._euler[1], -30f);
            tanganKanan3.rotate(kaca._centerPosition, tanganKanan3._euler[2], 95f);
            tanganKanan3.rotate(kaca._centerPosition, tanganKanan3._euler[0], 300f);
            Canon2.createEllipsoid2(0.03f, 0.03f, 0.4f, -0.4f, 0, -0f, 72, 24);
            Canon2.rotate(kaca._centerPosition, Canon2._euler[1], 330f);
            bulan1.createEllipsoid2(3f, 3f, 3f, 35f, 10f, -10f, 72, 24);
            bulan2.createEllipsoid2(3f, 3f, 3f, 35f, 25f, -10f, 72, 24);
            bulan3.createEllipsoid2(4f, 4f, 4f, -5f, 20f, -10f, 72, 24);
            bulan4.createEllipsoid2(10f, 10f, 10f, 25f, 30f, -10f, 72, 24);
            tanah1.createEllipsoid2(12.5f, 12.5f, 12.5f, -10f, 22.5f, -15f, 72, 24);
            bintang1.createEllipsoid2(1f, 1f, 1f, -0, 30f, -40f, 72, 24);
            bintang2.createEllipsoid2(1f, 1f, 1f, -40, 10f, -40f, 72, 24);
            bintang3.createEllipsoid2(1f, 1f, 1f, -10, 50f, -40f, 72, 24);
            bintang4.createEllipsoid2(1f, 1f, 1f, -20, 40f, -40f, 72, 24);
            bintang5.createEllipsoid2(1f, 1f, 1f, 40, 50f, -40f, 72, 24);
            bintang6.createEllipsoid2(1f, 1f, 1f, 25, 10f, -40f, 72, 24);
            bintang7.createEllipsoid2(1f, 1f, 1f, 10, 30f, -40f, 72, 24);
            bintang8.createEllipsoid2(1f, 1f, 1f, 55, 25f, -40f, 72, 24);
            bintang9.createEllipsoid2(1f, 1f, 1f, 6.9f, 10f, -40f, 72, 24);
            bintang10.createEllipsoid2(1f, 1f, 1f, -50, 35f, -40f, 72, 24);
            bintang11.createEllipsoid2(1f, 1f, 1f, -40, 20f, -40f, 72, 24);
            bintang12.createEllipsoid2(1f, 1f, 1f, -25, 5f, -40f, 72, 24);
            ujung.createEllipsoid2(0.02f, 0.02f, 0.02f, -0.005f, 0.49f, 0.4f, 72, 24);
            peluru2.createEllipsoid2(0.01f, 0.01f, 0.04f, -0.495f, 0, 0.05f, 72, 24);
            peluru1.createEllipsoid2(0.01f, 0.01f, 0.04f, 0.24f, 0, 0.32f, 72, 24);
        
            __object.Add(utama);
            __object.Add(mulut1);
            __object.Add(tanganKiri1);
            __object.Add(tanganKanan1);
            __object.Add(bulan1);
            __object.Add(tanah1);
            __object.Add(peluru1);
            __object.Add(peluru2);
            __object[0].child.Add(kaca);
            __object[0].child.Add(tanganKiri1);
            __object[0].child.Add(tanganKiri2);
            __object[0].child.Add(tanganKiri3);
            __object[0].child.Add(Canon1);
            __object[0].child.Add(tanganKanan1);
            __object[0].child.Add(tanganKanan2);
            __object[0].child.Add(tanganKanan3);
            __object[0].child.Add(Canon2);
            __object[0].child.Add(Mata1);
            __object[0].child.Add(Mata2);
            __object[0].child.Add(mulut1);
            __object[0].child.Add(peluru1);
            __object[0].child.Add(peluru2);
            __object[0].child.Add(bulan2);
            __object[0].child.Add(bulan3);
            __object[0].child.Add(bulan4);
            utama.child.Add(ujung);
            utama.child.Add(bulan1);
            tanah1.child.Add(bintang1);
            tanah1.child.Add(bintang2);
            tanah1.child.Add(bintang3);
            tanah1.child.Add(bintang4);
            tanah1.child.Add(bintang5);
            tanah1.child.Add(bintang6);
            tanah1.child.Add(bintang7);
            tanah1.child.Add(bintang8);
            tanah1.child.Add(bintang9);
            tanah1.child.Add(bintang10);
            tanah1.child.Add(bintang11);
            tanah1.child.Add(bintang12);

            antena11.AddCoords(-0f, 0.2f, 0f);
            antena11.AddCoords(-0f, 0.5f, 0f);
            antena11.AddCoords(-0f, 0.8f, 0.1f);
            antena11.AddCoords(-0f, 0.7f, 0.2f);
            antena11.AddCoords(-0f, 0.6f, 0.35f);
            antena11.AddCoords(-0f, 0.5f, 0.375f);
            antena11.Bezier(6);
            utama.child.Add(antena11);



            antena.AddCoords(-0.45f, 0.2f, 0.5f);
            antena.AddCoords(-0.45f, 0.5f, 0.5f);
            antena.AddCoords(-0.45f, 1.5f, 0.5f);
            antena.AddCoords(-0.45f, 2f, 0.5f);
            antena.AddCoords(-0.45f, 0.5f, 1f);
            antena.Bezier(5);

            antenakanan.AddCoords(0.45f, 0.2f, 0.5f);
            antenakanan.AddCoords(0.45f, 0.5f, 0.5f);
            antenakanan.AddCoords(0.45f, 1.5f, 0.5f);
            antenakanan.AddCoords(0.45f, 2f, 0.5f);
            antenakanan.AddCoords(0.45f, 0.5f, 1f);
            antenakanan.Bezier(5);

            kubus.createBoxVertices(0, 0, 0, 1f);
            badan.createCuboid(0, -1.2f, 0, 1.1f, 1.2f, 0.75f);
            pantat.createCuboid(0, -2.05f, 0, 1f, 0.5f, 0.75f);
            tangankanan.createCuboid(0.625f, -1.25f, 0, 0.25f, 1f, 0.2f);
            tangankiri.createCuboid(-0.625f, -1.25f, 0, 0.25f, 1f, 0.2f);
            titikbuntut.createEllipsoid2(0.1f, 0.1f, 0.1f, 0, -2.1f, 0, 24, 72);
            tanah.createCuboid(0, -5f, 0, 100, 0, 100);
            //kubus.createEllipsoid2(2, 2, 2, 0.1f, 0.1f, 0.1f, 72, 24);
            _object.Add(kubus);//0
            _object.Add(badan);//1
            _object.Add(pantat);//2
            _object.Add(tangankanan);//3
            _object.Add(tangankiri);//4
            _object.Add(kakikanan);//5
            _object.Add(kakikiri);//6
            _object.Add(titikbuntut);//7
            _object.Add(tanah);
            //var kubus1 = new Asset_3D(new Vector3(1,1,1));           
            //kubus1.createBoxVertices(0, 0, 0.5f, 0.5f);
            titiktengah.createBoxVertices(0f, -0.8F, 0f, 0.1f);
            telapaktkanan.createEllipsoid2(0.15f, 0.15f, 0.15f, 0.625f, -1.75f, 0f, 72, 24);
            telapaktkiri.createEllipsoid2(0.15f, 0.15f, 0.15f, -0.625f, -1.75f, 0f, 72, 24);
            leher.createCuboid(0, -0.3f, 0, 0.4f, 1.2f, 0.4f);
            kakikanan.createCuboid(0.3f, -2.6f, 0, 0.4f, 1f, 0.5f);
            kakikiri.createCuboid(-0.3f, -2.6f, 0, 0.4f, 1f, 0.5f);
            buntut.createCone(0, -1.05f, 2.1f, 0.05f, 0.7f, 0.1f, 72, 24);
            kubus2.createEllipsoid2(0.1f, 0.1f, 0.1f, 0.3f, 0.3f, 0.5f, 72, 24);
            kubus3.createEllipsoid2(0.1f, 0.1f, 0.1f, -0.3f, 0.3f, 0.5f, 72, 24);
            kubus4.createEllipsoid(0.2f, 0.2f, 0.2f, 0f, -0.2f, 0.4f, 72, 24);
            kubus5.createEllipsoid2(0.05f, 0.05f, 0.05f, 0.3f, 0.3f, 0.6f, 72, 24);
            kubus6.createEllipsoid2(0.05f, 0.05f, 0.05f, -0.3f, 0.3f, 0.6f, 72, 24);
            buntut.rotate(Vector3.UnitX, Vector3.UnitX, 90f);
            //_object[0].child.Add(kubus1);
            kubus.child.Add(kubus2);
            kubus.child.Add(kubus3);
            kubus.child.Add(kubus4);
            kubus.child.Add(kubus5);
            kubus.child.Add(kubus6);
            kubus.child.Add(antena);
            kubus.child.Add(antenakanan);
            badan.child.Add(leher);
            badan.child.Add(kubus);
            badan.child.Add(pantat);
            badan.child.Add(tangankanan);
            badan.child.Add(tangankiri);
            badan.child.Add(titiktengah);
            pantat.child.Add(buntut);
            titikbuntut.child.Add(buntut);
            //pantat.child.Add(kakikanan);
            //pantat.child.Add(kakikiri);
            tangankanan.child.Add(telapaktkanan);
            tangankiri.child.Add(telapaktkiri);

            foreach (var i in _object)
            {
                i.OnLoad(Warna.col + "shader.vert", Warna.col + "shader.frag", Size.X, Size.Y);
            }

            foreach (var i in __object)
            {
                i.OnLoad(Warna.col + "shader.vert", Warna.col + "shader.frag", Size.X, Size.Y);
            }


            _camera = new Camera(new Vector3(0, 0, 5), Size.X / Size.Y);
            //CursorGrabbed = true;
            //_shader = new Shader(Warna.col + "shader.vert", Warna.col + "shader.frag");
            //_shader.Use();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            _time = (float)args.Time;
            _intime += (float)args.Time * 10;
            __object[0].OnRender(3, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            tanah1.OnRender(3, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            __object[__object.Count - 1].OnRender(3, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            antena11.OnRender(1, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            Console.WriteLine(_time * 30);

        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
            _object[0].OnRender(0, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            _object[1].OnRender(0, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            _object[2].OnRender(0, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            _object[5].OnRender(0, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            _object[6].OnRender(0, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            antena.OnRender(1, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            antenakanan.OnRender(1, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            tanah.OnRender(0, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
            _intime += (float)args.Time * 10;
            
            //kubus.translate(0, 0.25f, 0);
            //leher.translate(0, 0.1f, 0);
            if (_intime <= 30)
            {
                badan.scale(1.005f, badan._centerPosition);
                kakikanan.scale(1.005f, buntut._centerPosition);
                kakikiri.scale(1.005f, buntut._centerPosition);
                kakikanan.translate(0, 0.003f, -0.008f);
                kakikiri.translate(0, 0.003f, -0.008f);
                _object[1].rotate(_object[2]._centerPosition, _object[1]._euler[0], _time * 60);
                utama.scale(1.005f, utama._centerPosition);
                utama.rotate(utama._centerPosition, utama._euler[1], _time * 20);
            }
            else if (_intime <= 60)
            {

                utama.translate(0, 0.005f, 0.019f);
                _object[4].rotate(titiktengah._centerPosition, _object[4]._euler[0], -_time * 60);
                _object[3].rotate(titiktengah._centerPosition, _object[3]._euler[0], -_time * 60);
            }
            else if (_intime > 60 && _intime < 90)
            {

                leher.translate(0, 0, 0.00001f);
                //_object[0].translate(0, -0.0001f, 0.00015f);
                _object[0].translate(0, -0.012f, 0.0039f);
                _object[0].rotate(leher._centerPosition, _object[0]._euler[0], -_time * 60);
                tangankanan.translate(0,-0.002f,0f);
                tangankiri.translate(0, -0.002f, 0f);

            }

            else if (_intime < 95)
            {
                titikbuntut.rotate(titikbuntut._centerPosition, buntut._euler[2], _time * 80);
                kakikanan.rotate(pantat._centerPosition, kakikanan._euler[0], -_time * 80);
                kakikiri.rotate(pantat._centerPosition, kakikiri._euler[0], _time * 80);
                tangankanan.rotate(titiktengah._centerPosition, tangankanan._euler[0], -_time * 80);
                tangankiri.rotate(titiktengah._centerPosition, tangankiri._euler[0], _time * 80);
                tanganKanan3.rotate(kaca._centerPosition, tanganKanan3._euler[0], _time * 120);
                tanganKiri3.rotate(kaca._centerPosition, tanganKiri3._euler[0], _time * 120);
                tanganKanan3.scale(1.01f, tanganKanan3._centerPosition);
                tanganKiri3.scale(1.01f, tanganKiri3._centerPosition);
                tanah1.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan1.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan2.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan3.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan4.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bintang1.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang2.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang3.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang4.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang5.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang6.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang7.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang8.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang9.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang10.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang11.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang12.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                //badan.translate(0.0f, 0.0f, 0.01f);
                //kakikanan.translate(0.0f, 0.0f, 0.01f);
                //kakikiri.translate(0.0f, 0.0f, 0.01f);
                //tanah.translate(0.0f, 0.0f, 0.01f);
                //utama.translate(0.0f, 0, 0.01f);

            }
            else if (_intime < 105)
            {

                titikbuntut.rotate(titikbuntut._centerPosition, buntut._euler[2], -_time * 80);
                kakikanan.rotate(pantat._centerPosition, kakikanan._euler[0], _time * 80);
                kakikiri.rotate(pantat._centerPosition, kakikiri._euler[0], -_time * 80);
                tangankanan.rotate(titiktengah._centerPosition, tangankanan._euler[0], _time * 80);
                tangankiri.rotate(titiktengah._centerPosition, tangankiri._euler[0], -_time * 80);
                tanganKanan3.rotate(kaca._centerPosition, tanganKanan3._euler[0], _time * 120);
                tanganKiri3.rotate(kaca._centerPosition, tanganKiri3._euler[0], _time * 120);
                tanganKanan3.scale(0.99f, tanganKanan3._centerPosition);
                tanganKiri3.scale(0.99f, tanganKiri3._centerPosition);
                tanah1.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan1.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan2.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan3.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan4.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bintang1.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang2.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang3.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang4.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang5.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang6.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang7.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang8.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang9.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang10.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang11.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang12.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                //badan.translate(0.0f, 0.0f, 0.01f);
                //kakikanan.translate(0.0f, 0.0f, 0.01f);
                //kakikiri.translate(0.0f, 0.0f, 0.01f);
                //tanah.translate(0.0f, 0.0f, 0.01f);
                //utama.translate(0.0f, 0f, 0.01f);
            }
            else if (_intime < 110)
            {

                titikbuntut.rotate(titikbuntut._centerPosition, buntut._euler[2], _time * 80);
                kakikanan.rotate(pantat._centerPosition, kakikanan._euler[0], -_time * 80);
                kakikiri.rotate(pantat._centerPosition, kakikiri._euler[0], _time * 80);
                tangankanan.rotate(titiktengah._centerPosition, tangankanan._euler[0], -_time * 80);
                tangankiri.rotate(titiktengah._centerPosition, tangankiri._euler[0], _time * 80);
                tanganKanan3.rotate(kaca._centerPosition, tanganKanan3._euler[0], _time * 120);
                tanganKiri3.rotate(kaca._centerPosition, tanganKiri3._euler[0], _time * 120);
                tanganKanan3.scale(1.01f, tanganKanan3._centerPosition);
                tanganKiri3.scale(1.01f, tanganKiri3._centerPosition);
                //badan.translate(0.0f, 0.0f, 0.01f);
                //kakikanan.translate(0.0f, 0.0f, 0.01f);
                //kakikiri.translate(0.0f, 0.0f, 0.01f);
                //tanah.translate(0.0f, 0.0f, 0.01f);
                //utama.translate(0.0f, 0.0f, 0.01f);

                bulan1.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan2.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan3.rotate(badan._centerPosition, badan._euler[2], _time * 60);
                bulan4.rotate(badan._centerPosition, badan._euler[2], _time * 600);
                bintang1.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang2.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang3.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang4.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang5.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang6.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang7.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang8.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang9.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang10.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang11.rotate(badan._centerPosition, badan._euler[2], _time * 120);
                bintang12.rotate(badan._centerPosition, badan._euler[2], _time * 120);
            }
            if (_intime > 110)
            {
                _intime = 90;
            }

            if (tembakdepan)
            { 
                peluru1.translate(0.0f, 0, 0.05f);
                peluru2.translate(0.0f, 0, 0.05f);
                temp += 0.05f;
            }
            if (!tembakdepan)
            {
                peluru1.translate(0.0f, 0, -temp);
                peluru2.translate(0.0f, 0, -temp);
                temp = 0;
            }
            SwapBuffers();
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0,0,Size.X,Size.Y);
            _camera.AspectRatio = Size.X / (float)Size.Y;
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);
            _camera.Fov = _camera.Fov - e.OffsetY;
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            var input = KeyboardState;
            if (input.IsKeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys.Escape))
            {
                Close();
            }
            float cameraSpeed = 5f;

            if (KeyboardState.IsKeyDown(Keys.W))
            {
                _camera.Position += _camera.Front * cameraSpeed * (float)args.Time;
            }
            if (KeyboardState.IsKeyDown(Keys.S))
            {
                _camera.Position -= _camera.Front * cameraSpeed * (float)args.Time;
            }
            if (KeyboardState.IsKeyDown(Keys.A))
            {
                _camera.Position -= _camera.Right * cameraSpeed * (float)args.Time;
            }
            if (KeyboardState.IsKeyDown(Keys.D))
            {
                _camera.Position += _camera.Right * cameraSpeed * (float)args.Time;
            }
            if (KeyboardState.IsKeyDown(Keys.Space))
            {
                _camera.Position += _camera.Up * cameraSpeed * (float)args.Time;
            }
            if (KeyboardState.IsKeyDown(Keys.LeftShift))
            {
                _camera.Position -= _camera.Up * cameraSpeed * (float)args.Time;
            }
            if (KeyboardState.IsKeyDown(Keys.N))
            {
                var axis = new Vector3(0, 1, 0);
                _camera.Position -= _objectposition;
                _camera.Position = Vector3.Transform(
                    _camera.Position,
                    generateArbRotationMatrix(axis, _rotationSpeed)
                    .ExtractRotation());
                _camera.Position += _objectposition;
                _camera._front = -Vector3.Normalize(_camera.Position
                    - _objectposition);
            }
            if (KeyboardState.IsKeyDown(Keys.Comma))
            {
                var axis = new Vector3(0, 1, 0);
                _camera.Position -= _objectposition;
                _camera.Yaw -= _rotationSpeed;
                _camera.Position = Vector3.Transform(_camera.Position,
                    generateArbRotationMatrix(axis, -_rotationSpeed)
                    .ExtractRotation());
                _camera.Position += _objectposition;

                _camera._front = -Vector3.Normalize(_camera.Position - _objectposition);
            }
            if (KeyboardState.IsKeyDown(Keys.K))
            {
                var axis = new Vector3(1, 0, 0);
                _camera.Position -= _objectposition;
                _camera.Pitch -= _rotationSpeed;
                _camera.Position = Vector3.Transform(_camera.Position,
                    generateArbRotationMatrix(axis,  _rotationSpeed).ExtractRotation());
                _camera.Position += _objectposition;
                _camera._front = -Vector3.Normalize(_camera.Position - _objectposition);
            }
            if (KeyboardState.IsKeyDown(Keys.M))
            {
                var axis = new Vector3(1, 0, 0);
                _camera.Position -= _objectposition;
                _camera.Pitch += _rotationSpeed;
                _camera.Position = Vector3.Transform(_camera.Position,generateArbRotationMatrix(axis, -_rotationSpeed).ExtractRotation());
                _camera.Position += _objectposition;
                _camera._front = -Vector3.Normalize(_camera.Position - _objectposition);
            }
            if (KeyboardState.IsKeyDown(Keys.P))
            {
                tembakdepan = true;
                peluru1.scale(1.00001f, peluru1._centerPosition);
                peluru1.scale(1.00001f, peluru1._centerPosition);
            }
            var mouse = MouseState;
            var sensitivity = 0.5f;
            if (KeyboardState.IsKeyDown(Keys.T))
            {
                utama.rotate(utama._centerPosition, utama._euler[2], -_time * 20);
                utama.rotate(utama._centerPosition, utama._euler[0], -_time * 20);
            }
            if (KeyboardState.IsKeyDown(Keys.H))
            {
                utama.rotate(utama._centerPosition, utama._euler[1], _time * 20);
            }
            if (KeyboardState.IsKeyDown(Keys.F))
            {
                utama.rotate(utama._centerPosition, utama._euler[1], -_time * 20);
            }
            if (KeyboardState.IsKeyDown(Keys.G))
            {
                utama.rotate(utama._centerPosition, utama._euler[2], _time * 20);
                utama.rotate(utama._centerPosition, utama._euler[0], _time * 20);
            }
            if (KeyboardState.IsKeyDown(Keys.Up))
            {
                tembakdepan = false;
                badan.translate(0.0f, 0.0f, 0.01f);
                kakikanan.translate(0.0f, 0.0f, 0.01f);
                kakikiri.translate(0.0f, 0.0f, 0.01f);
                //tanah.translate(0.0f, 0.0f, 0.01f);
                utama.translate(0.0f, 0, 0.01f);
                belakang = false;
            }
            //if (KeyboardState.IsKeyDown(Keys.Right))
            //{
            //    badan.translate(0.01f,0,0);
            //    kakikanan.translate(0.01f,0,0);
            //    kakikiri.translate(0.01f,0,0);
            //    //tanah.translate(0.0f, 0.0f, 0.01f);
            //    utama.translate( 0.01f,0,0);
            //    titikbuntut.translate(0.000001f, 0, 0);
            //}
            //if (KeyboardState.IsKeyDown(Keys.Left))
            //{
            //    badan.translate(-0.01f,0,0);
            //    kakikanan.translate(-0.01f,0,0);
            //    kakikiri.translate(-0.01f,0,0);
            //    //tanah.translate(0.01f,0,0);
            //    utama.translate(-0.01f,0,0);
            //    titikbuntut.translate(-0.000001f, 0, 0);
            //}
            if (KeyboardState.IsKeyDown(Keys.Down))
            {
                tembakdepan = false;
                badan.translate(0.0f, 0.0f, -0.01f);
                kakikanan.translate(0.0f, 0.0f, -0.01f);
                kakikiri.translate(0.0f, 0.0f, -0.01f);
                //tanah.translate(0.0f, 0.0f, -0.01f);
                utama.translate(0.0f, 0, -0.01f);
                //belakang = true;
                //utama.rotate(utama._centerPosition, utama._euler[1], 180f);
            }
            if (_firstMove == true)
            {
                _lastposition = new Vector2(mouse.X, mouse.Y);
                _firstMove = false;
            }
            else
            {
                var deltaX =mouse.X - _lastposition.X;
                var deltaY =mouse.Y - _lastposition.Y;
                _lastposition = new Vector2(mouse.X,mouse.Y);
                _camera.Yaw += deltaX *sensitivity;
                _camera.Pitch -= deltaY *sensitivity;
            }
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButton.Left)
            {
                float _x = (MousePosition.X - Size.X / 2) / (Size.X / 2);
                float _y = -(MousePosition.Y - Size.Y / 2) / (Size.Y / 2);

                Console.WriteLine("X= " + _x + " y =" + _y);
                

            }
        }
        public Matrix4 generateArbRotationMatrix(Vector3 axis, float angle)
        {
            angle = MathHelper.DegreesToRadians(angle);

            var arbRotationMatrix = new Matrix4(
                (float)Math.Cos(angle) + (float)Math.Pow(axis.X, 2) * (1 - (float)Math.Cos(angle)), axis.X * axis.Y * (1 - (float)Math.Cos(angle)) - axis.Z * (float)Math.Sin(angle), axis.X * axis.Z * (1 - (float)Math.Cos(angle)) + axis.Y * (float)Math.Sin(angle), 0,
                axis.Y * axis.X * (1 - (float)Math.Cos(angle)) + axis.Z * (float)Math.Sin(angle), (float)Math.Cos(angle) + (float)Math.Pow(axis.Y, 2) * (1 - (float)Math.Cos(angle)), axis.Y * axis.Z * (1 - (float)Math.Cos(angle)) - axis.X * (float)Math.Sin(angle), 0,
                axis.Z * axis.X * (1 - (float)Math.Cos(angle)) - axis.Y * (float)Math.Sin(angle), axis.Z * axis.Y * (1 - (float)Math.Cos(angle)) + axis.X * (float)Math.Sin(angle), (float)Math.Cos(angle) + (float)Math.Pow(axis.Z, 2) * (1 - (float)Math.Cos(angle)), 0,
0, 0, 0, 1
                );

            return arbRotationMatrix;

        }
    }
}
