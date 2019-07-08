# Escape-Game
Projecto final para IHC con realidad virtual, multijugador controlado por una bicicleta estacionaria y un smartphone
# Descripción
El objetivo de este proyecto es desarrollar un juego multijugador, en el cual ambos manejaran una bicicleta virtual, en un ambiente donde tienen que alcanzar un objetivo cada uno, con un tiempo limite, al realizar dicha tarea ambos podrán cruzar al siguiente nivel porque la puerta se habrá abierto. Los jugadores harán uso de diferente plataformas uno de ellos tendrá que manejar una bicicleta fija real implementada con sensores que controlara la velocidad, el freno y las direcciones que el usuario decida, para ver el entorno virtual se le dará un casco o un visor. El otro jugador mediante una aplicación descargada en su celular android podrá manejar mediante el giroscopio del celular, la velocidad y la dirección de la bicicleta virtual. Ambos contaran con un mini mapa el cual les indicara su posición actual y los objetivos a conseguir.

![Ambiente virtual](https://github.com/TSffer/-Escape-Game/blob/master/ambiente.png)

# Herramientas:
Unity3D: Entorno de desarrollo.Android  

SDK:  Es  el  software  utilizado  para  realizar  lacompilacion  en  dispositivos  Android.  Unity  lo  utilizapara la compilaci ́on desde su framework.GoogleVRForUnity: Software incluido en Unity que ge-nera  la  vision  en  un  entorno  virtual  desde  dos  camarasseparadas en la distancia adecuada para realidad virtual.Permite realizar pruebas desde el editor de Unity.

Environment Low Poly Assets: Desde el Asset Store deUnity, se descargo componentes  en tres dimensiones dearboles , rocas, etc;ArduinoMouse inal ́ambrico.

# Modelo:

Calculo de velocidad: Este modulo se encarga del c ́alculode  velocidad  recibiendo  como  entrada  los  mensajes  delArduino capturados por un sensor magnetico.

Calculo  de  rotacion:  Este  m ́odulo  es  el  encargado  decalcular  la  rotaci ́on  dentro  del  mundo  virtual  al  recibirlas posiciones del mouse en la pantalla.

Calculo de posicion: Es el encargado de ubicar al perso-aje en el mundo virtual. Para ello utiliza los valores delc ́alculo  de  velocidad  y  el  calculo  de  rotacion  sumando a  los  objetos  del  entorno,  como  la  altura  del  piso  en  elcual  se  est ́a  recorriendo,  ası  como  objetos  con  los  quepueda colisionar, como piedras o ́arboles.

Multijugador:  Es  el  encargado  de  enviar  los  datos  asincronizar  entre  el  servidor  (genera  la  partida)  y  elcliente (es el ciclista). Este env ́ıa datos vıa Wifi.

Conexion red: Unet componente de Unity que proporciona la conexion networking.
