#pragma strict
var playNormal : Texture2D;
var playHover : Texture2D;
var sound : AudioClip;

function Start () {

}
function OnMouseEnter () {
	audio.PlayOneShot(sound);
	guiTexture.texture = playNormal;
}
function OnMouseExit()
{	
	audio.PlayOneShot(sound);
	guiTexture.texture = playHover;
}
function OnMouseDown()
{
	audio.PlayOneShot(sound);
	Application.LoadLevel("KinghtCat");
}