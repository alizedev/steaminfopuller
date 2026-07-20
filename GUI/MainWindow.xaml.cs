<Window x:Class="SteamInfoPuller.GUI.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="CS2 Profile Analyzer"
        Width="1200"
        Height="700"
        Background="#0B1118">

    <Grid Margin="20">

        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>


        <!-- Titel -->
        <TextBlock Text="CS2 Profile Analyzer"
                   Foreground="White"
                   FontSize="32"
                   FontWeight="Bold"/>



        <!-- Hauptbereich -->
        <Grid Grid.Row="1"
              Margin="0,30,0,0">

            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="300"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>



            <!-- Profil -->
            <Border Background="#171D25"
                    CornerRadius="15"
                    Padding="20">

                <StackPanel>

                    <TextBlock Text="Steam Profil"
                               Foreground="Gray"
                               FontSize="18"/>

                    <TextBlock Text="{Binding Username}"
                               Foreground="White"
                               FontSize="25"
                               Margin="0,15,0,0"/>

                    <TextBlock Text="{Binding SteamId}"
                               Foreground="#AAAAAA"/>


                    <Button Content="Profil laden"
                            Height="40"
                            Margin="0,25,0,0"
                            Command="{Binding LoadCommand}"/>

                </StackPanel>

            </Border>



            <!-- Stats -->
            <WrapPanel Grid.Column="1"
                       Margin="20,0,0,0">


                <!-- VAC -->
                <Border Width="220"
                        Height="120"
                        Background="#171D25"
                        CornerRadius="15"
                        Margin="10">

                    <StackPanel Margin="15">

                        <TextBlock Text="VAC STATUS"
                                   Foreground="Gray"/>

                        <TextBlock Text="{Binding BanStatus}"
                                   Foreground="{Binding BanColor}"
                                   FontSize="25"
                                   FontWeight="Bold"/>

                    </StackPanel>

                </Border>



                <!-- Premier -->
                <Border Width="220"
                        Height="120"
                        Background="#171D25"
                        CornerRadius="15"
                        Margin="10">

                    <StackPanel Margin="15">

                        <TextBlock Text="PREMIER"
                                   Foreground="Gray"/>

                        <TextBlock Text="{Binding PremierRating}"
                                   Foreground="{Binding PremierColor}"
                                   FontSize="30"
                                   FontWeight="Bold"/>

                    </StackPanel>

                </Border>



                <!-- FACEIT -->
                <Border Width="220"
                        Height="120"
                        Background="#171D25"
                        CornerRadius="15"
                        Margin="10">

                    <StackPanel Margin="15">

                        <TextBlock Text="FACEIT"
                                   Foreground="Gray"/>

                        <TextBlock Text="{Binding FaceitLevel}"
                                   Foreground="#FF8800"
                                   FontSize="30"/>

                        <TextBlock Text="{Binding FaceitElo}"
                                   Foreground="White"/>

                    </StackPanel>

                </Border>



                <!-- Leetify -->
                <Border Width="220"
                        Height="120"
                        Background="#171D25"
                        CornerRadius="15"
                        Margin="10">

                    <StackPanel Margin="15">

                        <TextBlock Text="LEETIFY"
                                   Foreground="Gray"/>

                        <TextBlock Text="{Binding LeetifyScore}"
                                   Foreground="#66FF66"
                                   FontSize="30"/>

                    </StackPanel>

                </Border>



                <!-- Matches -->
                <DataGrid Width="700"
                          Height="250"
                          Margin="10"
                          ItemsSource="{Binding Matches}"
                          AutoGenerateColumns="True"/>


            </WrapPanel>

        </Grid>

    </Grid>

</Window>