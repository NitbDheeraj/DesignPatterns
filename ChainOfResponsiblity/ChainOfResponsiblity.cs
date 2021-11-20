using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblity
{
    /**
     The GoF book says that the Chain of Responsibility design pattern should
     “Avoid coupling the sender of a request to its receiver by giving more than
     one object a chance to handle the request. Chain the receiving objects and
     pass the request along the chain until an object handles it.”


    You use this pattern when not all your observers are created equal. For example, say that you have a layered application with a set chain of command for
    events — a mouse event may originate in a particular control, then bubble up
    to the control’s container, then the container’s window, and eventually up to
    the application itself. The first object that can handle the event correctly
    should grab it and stop the event from further bubbling.

    In other words, if you want to process your notifications using a hierarchical
    chain of objects, this is your pattern.

    Here’s an example which implements a help interface in a layered application.
    Say the user right-clicks an element in the UI and requests help for a particular
    visual element. If the front end of the application can handle the help request, it
    will handle that request; if it can’t, it passes that request on to the intermediate
    layer of the application; if the help request still can’t be handled, it’s passed on
    to the application object itself, which displays a default message.
    **/


    // Common Interface
    public interface IChainOfResponsiblity
    {
        void getHelp(int helpConstant);
    }


    /*
        The front end can only handle help requests about the front end, for which there is a conastant FRONT_END_HELP. If the constant passed to the FrontEnd
        object’s getHelp method is not FRONT_END_HELP, it should pass the help
        request to the next object in the chain; otherwise, it knows it can handle 
        this help request and will display a help message as you can see in the following code:
     */
    public class FrontEnd : IChainOfResponsiblity
    {
        private const int FRONT_END_HELP = 1;
        IChainOfResponsiblity _successor;
        public FrontEnd(IChainOfResponsiblity s)
        {
            _successor = s;
        }
        public void getHelp(int helpConstant)
        {
            if (helpConstant != FRONT_END_HELP)
                _successor.getHelp(helpConstant);
            else
                Console.WriteLine("This is the front end. Don’t you like it ?");
        }
    }

    /*  The intermediate layer, class IntermediateLayer, can handle help requests
        corresponding to the Intermediate_Layer_Help constant. If it gets passed
        that constant in the getHelp method, it displays a help message — otherwise,
        it passes the help request on to the next object in the chain.
     */
    public class IntermediateLayer : IChainOfResponsiblity
    {
        private const int Intermediate_Layer_Help = 1;
        IChainOfResponsiblity _successor;
        public IntermediateLayer(IChainOfResponsiblity s)
        {
            _successor = s;
        }
        public void getHelp(int helpConstant)
        {
            if (helpConstant != Intermediate_Layer_Help)
                _successor.getHelp(helpConstant);
            else
                Console.WriteLine("This is the intermediate layer. Nice, eh?");
        }
    }

    /*
        The end of the chain is the Application object; the buck stops here. There
        is no successor to this link in the chain, so if the getHelp method is called in
        the Application object, it just displays a default message 
     */
    public class Application : IChainOfResponsiblity
    {
        public void getHelp(int helpConstant)
        {
            Console.WriteLine("This is the application layer baby!!");
        }
    }
}
