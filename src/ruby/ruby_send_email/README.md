Hello, this repository contains an example of sending an email through the terminal. The program is written in the Ruby programming language.
I was taking a course on the basics of Ruby and after one lesson I decided to improve the example and post it.

To install Ruby, you need to run commands in the terminal:

```bash Debian or Ubuntu
sudo apt-get install ruby-full
```
```bash CentOS, Fedora, or RHEL
sudo yum install ruby
```
```bash Arch Linux
sudo pacman -S ruby
```
```bash Homebrew (macOS)
brew install ruby
```
```bash FreeBSD
pkg install ruby
```

, or if you are using Windows, then you need to install from the following [source](https://rubyinstaller.org/downloads/).

Also, for this program, you need to install the following gems:
```bash
gem install pony
```

To run the application, just go to the directory with the source code of the program and send the following command:
```bash
ruby send_email.rb
```