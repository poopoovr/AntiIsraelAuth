STEPS: 
drag the antiIauthprotection file into your project folder.
open your main plugin file and add antiIauthprotection.initialize(this); inside your awake method.
to make sure it runs before anything can load, change your plugin guid so it starts with 0000.
