# Blazor.Todo

[Add tailwind CSS](https://chrissainty.com/adding-tailwind-css-v3-to-a-blazor-app/)

In the app folder run below command(s).

If tailwind not installed please execute this first.

```bash
npm install -g tailwindcss
```

and run this command once tailwind installed

```bash
npx tailwindcss init
```

It will create taildwind.config.js. Change following in tailwind.config.js to enable dark theme and css generation for both client and server.

```js
module.exports = {
  darkMode: "class",
  content: [
    "./**/*.{razor,html,cshtml}", // server
    "../**/*.{razor,html,cshtml}", // client (as it is outside)
  ],
  theme: {
    extend: {},
  },
  plugins: [],
};
```

Create a folder _Styles_ in server and _app.css_ and below css.

```css
@tailwind base;
@tailwind components;
@tailwind utilities;
```

Run below command to create css files.

```
npx tailwindcss -i ./Styles/app.css -o ./wwwroot/css/app.css --watch
```

Install _TailBlazor.HeroIcons_ from Nuget in _Server_.
