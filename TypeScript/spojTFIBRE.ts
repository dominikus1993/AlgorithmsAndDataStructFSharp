


var first = (array, predicate) => {
  return array.filter(x => predicate(x))[0];
}

var addElement = (array, element) => {
  var resultArray = array.map(x => x);
  resultArray.push(element);
  return resultArray;
}

class NodeElement{
  private _address:string;
  private _state:boolean;
  private _connections:NodeElement[];

  constructor(data:{address:string;state:boolean;connections:NodeElement[]}){
    this._address = data.address;
    this._state = data.state;
    this._connections = data.connections;
  }

  get address(){
    return this._address;
  }

  get state(){
    return this._state;
  }

  get connections(){
    return this._connections;
  }

  public createNewNodeWithOtherState(state:boolean){
    return new NodeElement({address:this._address,state:state,connections:this._connections});
  }
}

function createDefaultNodeElementByAddress(nodeAddress:string){
  return new NodeElement({address:nodeAddress,state:false,connections:[]})
}

class NodeCollector{
  private _nodes:NodeElement[];
  get nodes(){
    return this._nodes;
  }

  constructor(nodes:NodeElement[]){
    this._nodes = nodes;
  }
}

class NodeManager{
  private _nodes:NodeCollector;

  constructor(){
    this._nodes = new NodeCollector([]);
  }
  get nodes(){
    return this._nodes;
  }

  public input(command:string):boolean|string{
      const tmpCommand = command.split(/ /);
      if (tmpCommand[0] === "B") {
        this._nodes = this.addNodes(tmpCommand[1],tmpCommand[2]);
        return "";
      }
      else if(tmpCommand[0] === "T"){
        console.assert(tmpCommand[1] != tmpCommand[2]);
        const node1:NodeElement = first(this._nodes.nodes,x => x.address == tmpCommand[1]);
        const node2:NodeElement = first(this._nodes.nodes, x => x.address == tmpCommand[2]);
        console.log(`od ${tmpCommand[1]} do ${tmpCommand[2]}`);
        if (node1 && node2) {
          this._nodes = this.setConnectStateToFalse();
          return this.isConnect(node1, node2);
        }
        return false;
      }
  }


  private addNodes(address1:string, address2:string):NodeCollector{
    const nodes = this._nodes.nodes.map(x => x);
    var [node1, node2] = this.connectNodes(this.createOrGetNodeElement(address1), this.createOrGetNodeElement(address2));
    var result = nodes.filter(x => x.address != node1.address && x.address != node2.address);
    result = addElement(result, node1);
    result = addElement(result, node2);
    return new NodeCollector(result);
  }

  private createOrGetNodeElement(address:string){
    var result:NodeElement;
    if (this.checkAddressIsNotRepeated(address)) {
      result = createDefaultNodeElementByAddress(address)
    }
    else{
      result = first(this._nodes.nodes, x => x.address === address);
    }
    return result;
  }

  private checkAddressIsNotRepeated(address:string){
    return this._nodes.nodes.filter(x => x.address === address).length === 0;
  }

  private connectNodes(node1:NodeElement, node2:NodeElement){
    const newNode1 = new NodeElement({address:node1.address,state:node1.state,connections:addElement(node1.connections, node2)});
    const newNode2 = new NodeElement({address:node2.address,state:node2.state,connections:addElement(node2.connections, node1)});
    return [newNode1, newNode2];
  }

  private setConnectStateToFalse(){
    var nodes = this._nodes.nodes.map(x => x);
    nodes.forEach(x => x.state = false);
    return new NodeCollector(nodes);
  }

  private isConnect(node1:NodeElement, node2:NodeElement){
    node1 = node1.createNewNodeWithOtherState(true);
    console.log(`obecna komorka ${node1.address} jej polaczenia ${node1.connections.map(x => x.address)} cel ${node2.address}`)
    for (let connection of node1.connections) {
        if(!connection.state){
          if (connection.address === node2.address) {
              return true;
          }
          else{
            if (this.isConnect(connection, node2)) {
              return true;
            }
          }
        }
    }
    return false;
  }

}


const nodeFactory = new NodeManager();

console.log(nodeFactory.input("B 100.100.100.1 100.100.100.2"));
console.log(nodeFactory.input("B 100.100.100.1 100.100.100.3"));
console.log(nodeFactory.input("B 100.100.100.10 100.100.100.11"));
console.log(nodeFactory.input("T 100.100.100.1 100.100.100.3"));
console.log(nodeFactory.input("T 100.100.100.10 100.100.100.2"));
console.log(nodeFactory.input("T 100.100.100.10 100.100.100.11"));
console.log(nodeFactory.input("B 100.100.100.11 100.100.100.2"));
console.log(nodeFactory.input("T 100.100.100.2 100.100.100.3"));
console.log(nodeFactory.input("T 100.100.100.100 100.100.100.103"))
