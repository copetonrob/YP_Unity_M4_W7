# Задание 1: Кликер!

## Описание

В этом задании мы сделаем простую мини игру в жанре кликер. Мы создадим две сцены. Одна из них - это главное меню. Пока что в ней будет только кнопка "Начать игру". В основной сцене игры мы сделаем две кнопки. Одна из них будет прибавлять очки к нашему общему балансу. А вторая будет увеличивать коэффициент прибавления очков от первой кнопки за определенную стоимость.

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/Task1.gif" width="600"/>

## Инструкция

Создай сцену главного меню.

Создай кнопку "Начать игру".

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/create_button.png" width="400"/>

Обрати внимание, что при создании кнопки, если в сцене не было канваса, то он появляется автоматически. Настрой параметры канваса, чтобы он масштабировался вместе с экраном.

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/canvas_params.png" width="400"/>

Создай новый скрипт для перехода в сцену игры. Назови его, например, Menu. В нем объяви метод 

public void StartGameButton() 

и внутри него вызови 

SceneManager.LoadScene(1); 

Чтобы перейти на сцену с индексом 1.

Создай пустой объект, чтобы добавить в сцену скрипт меню.

Добавь в кнопку событие On Click и укажи ссылку на объект со скриптом. В качестве метода выбери метод StartGameButton()

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/button_on_click.png" width="800"/>

Создай пустую сцену для основной игры. Назови ее, например, Game

В окне build settings, добавь сцену меню и основной игры.

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/build_settings1.png" width="800"/>

Открой сцену игры. Создай текст и кнопку.

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/add_button.png" width="400"/>

Создай скрипт [Game.cs](https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/scripts/Game.cs) и скопируй в него содержимое

Создай пустой объект и навесь на него этот скрипт. Не забудь указать ссылку на текст с балансом очков.

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/score_text_ref.png" width="400"/>

Добавь событие по нажатию на кнопку "+1"

<img src="https://github.com/copetonrob/YP_Unity_M4_W7/blob/main/img/add_on_click.png" width="400"/>

Осталось еще добавить кнопку возврата в меню.  Создай эту кнопку в углу экрана и добавь в события ссылку на метод BackButton() в скрипте Game.

Запусти игру, проверь, что все работает. По нажатию на кнопку "+1" в баланс должно прибавляться значение и текст должен обновляться.
