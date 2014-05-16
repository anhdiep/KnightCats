#pragma strict
var MoreNormal : Texture2D;
var MoreHover : Texture2D;
var sound : AudioClip;
function Start () {

}

function OnMouseEnter () {
	audio.PlayOneShot(sound);
	guiTexture.texture = MoreNormal;
}
function OnMouseExit()
{
	audio.PlayOneShot(sound);
	guiTexture.texture = MoreHover;
}
function OnMouseDown()
{
	audio.PlayOneShot(sound);
	Application.LoadLevel("MoreGameScene");
}